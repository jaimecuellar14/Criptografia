using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSA;
using System.Xml;
using TDES;
using Conversores;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Maestro
{
    public partial class MaestroForm : Form
    {

        private string llavePrivada;
        private string llavePublica;
        private RSAParameters llavePublicaEsclavo;
        private string llaveTDES;
        private TDESKeyObject llavesTDES;
        private string llave1TDES;
        private string llave2TDES;
        private string llave3TDES;
        private string[] llavesTDESArray;
        private byte[] textoCifrado;
        private byte[] tdesKey;
        private string tdesString;
        private string iv;
        private System.Security.Cryptography.RSA cspEsclavo;

        public MaestroForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rsa = new RSA.RSAMaker();
            var llaves = rsa.CreateRSAKeyPair();


            var publica = new Conversores.ConvertirString().convertirStringPublica(llaves);
            var privada = new Conversores.ConvertirString().convertirStringPrivada(llaves);

            this.llavePublica = publica;
            this.llavePrivada = privada;

            this.txtLlavePublica.Text = new Conversores.ConvertirXML().convertirAXml(publica).InnerText;
            this.txtLlavePrivada.Text = new Conversores.ConvertirXML().convertirAXml(privada).InnerText;
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileBrowser = new OpenFileDialog();
            //fileBrowser.InitialDirectory = "C:\\Users\\Jaime\\Desktop";
            fileBrowser.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fileBrowser.Filter = "XML Files|*.xml";
            fileBrowser.RestoreDirectory = true;
            fileBrowser.ShowDialog();

            XmlDocument doc = new XmlDocument();

            doc.Load(fileBrowser.OpenFile());

            // var a = doc.LastChild.InnerText;
            var a = doc.GetElementsByTagName("clavepublica").Item(0).InnerText;
            var conversor = new ConvertirXML().convertirAXml(a);
            this.txtLlavePublicaEsclavo.Text = a;
            //var test = Convert.FromBase64String(a);
            this.crearRSAEsclavo(a);
            this.btnCrearTDES.Enabled = true;
        }

        private void btnCrearTDES_Click(object sender, EventArgs e)
        {
            var conversor = new Conversores.HexByteArray();
            var tdes = new TDES.TDESMaker();
            var llave = tdes.CrearLlavesTDES();
            this.tdesKey = llave.Key;
            this.llavesTDES = new TDESKeyObject().dividirArray(llave.Key);
            this.iv = conversor.ByteArrayToHex(llave.IV);
            
            this.llave1TDES = conversor.ByteArrayToHex(this.llavesTDES.tdesKey1);
            this.llave2TDES = conversor.ByteArrayToHex(this.llavesTDES.tdesKey2);
            this.llave3TDES = conversor.ByteArrayToHex(this.llavesTDES.tdesKey3);
            this.tdesString = conversor.ByteArrayToHex(this.tdesKey);
            this.llavesTDESArray = new string[] { this.llave1TDES, this.llave2TDES, this.llave3TDES };
            this.txtTDES.Text = this.llave1TDES + this.llave2TDES + this.llave3TDES;
            this.llaveTDES = this.txtTDES.Text;
            this.btnEncriptarTDES.Enabled = true;

        }

        public void crearRSAEsclavo(string llavePublica)
        {
            this.cspEsclavo = new System.Security.Cryptography.RSACryptoServiceProvider(512);
            this.cspEsclavo.FromXmlString(llavePublica);
            this.llavePublicaEsclavo = cspEsclavo.ExportParameters(false);
        }

        private void btnEncriptarTDES_Click(object sender, EventArgs e)
        {
            var encriptador = new Encriptador();
            var xmlLlavesTDES = new XDocument();
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("tdes");
            string tdes = null;
            for (var i = 0; i < this.llavesTDESArray.Length; i++)
            {
                var llavesTDESEncriptadas = encriptador.Encriptar(this.llavesTDESArray[i], this.cspEsclavo.ExportParameters(false));
                var llaveNum = i + 1;
                tdes += llavesTDESEncriptadas;
                XmlNode node = doc.CreateElement("tdes" + llaveNum);
                node.InnerText = llavesTDESEncriptadas;
                root.AppendChild(node);
                
            }
            XmlNode iv = doc.CreateElement("iv");
            iv.InnerText = encriptador.Encriptar(this.iv, this.llavePublicaEsclavo);
            root.AppendChild(iv);
            doc.AppendChild(root);

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "XML-File | *.xml";
            if (save.ShowDialog() == DialogResult.OK)
            {
                doc.Save(save.FileName);
                MessageBox.Show("Has guardado el fichero", "Llaves TDES");
            }
           // var tdesEncriptado = encriptador.Encriptar(this.tdesString, this.llavePublicaEsclavo);
            this.txtTDESEncriptado.Text = tdes;
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            var tdes = new TDES.TDESCript();
            var conversor = new Conversores.HexByteArray();
            var iv = conversor.StringToByteArray(this.iv);
            this.txtTextoOriginal.Text = tdes.Desencriptar(this.textoCifrado, this.tdesKey, iv);
        }

        private void btnImportarTexto_Click(object sender, EventArgs e)
        {
            var conversor = new Conversores.HexByteArray();
            OpenFileDialog fileBrowser = new OpenFileDialog();
            //fileBrowser.InitialDirectory = "C:\\Users\\Jaime\\Desktop";
            fileBrowser.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fileBrowser.Filter = "XML Files|*.xml";
            fileBrowser.RestoreDirectory = true;
            fileBrowser.ShowDialog();

            XmlDocument doc = new XmlDocument();

            doc.Load(fileBrowser.OpenFile());

            var textoEncriptado = doc.GetElementsByTagName("textoe").Item(0).InnerText;
            this.txtTextoEncriptado.Text = textoEncriptado;
            this.textoCifrado = conversor.StringToByteArray(textoEncriptado);   
        }
    }
}
