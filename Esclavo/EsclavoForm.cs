using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Conversores;
using System.Xml.Linq;
using TDES;


namespace Esclavo
{
    public partial class EsclavoForm : Form
    {
        private string llavePrivada;
        private string llavePublica;
        private string llave1;
        private string llave2;
        private string llave3;
        private System.Security.Cryptography.RSAParameters llavePrivadaRSA;
        private string l1;
        private string l2;
        private string l3;
        private string iv;
        private string iv2;
        private byte[] llaveTDES;

       // private byte[] llavePublica;
        public EsclavoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rsa = new RSA.RSAMaker();
            var llaves = rsa.CreateRSAKeyPair();
            this.llavePrivadaRSA = llaves.ExportParameters(true);

            var publica = new Conversores.ConvertirString().convertirStringPublica(llaves);
            var privada = new Conversores.ConvertirString().convertirStringPrivada(llaves);

            this.llavePublica = publica;
            this.llavePrivada = privada;

            this.txtPublica.Text = this.llavePublica;
            this.txtPrivada.Text = this.llavePrivada;
            this.button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.txtPublica.Text == "")
            {
                Console.WriteLine("Error no se encuentra ninguna llave publica para exportar");
            }
            if (this.txtPublica.Text != null)
            {
                var doc = new XmlDocument();
                doc.AppendChild(doc.CreateXmlDeclaration("1.0", "UTF-8", null));
                XmlNode nodo = doc.CreateElement("clavepublica");
                //this.getBytes(this.llavePublica);
                XmlElement root = doc.CreateElement("tdes");
                nodo.InnerText =(this.llavePublica);
                root.AppendChild(nodo);
                doc.AppendChild(root);
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "XML-File | *.xml";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    doc.Save(save.FileName);
                    MessageBox.Show("Has guardado el fichero","Llave publica");
                }
            }
        }

        private string getBytes(byte[] llavePublica)
        {
            string llave="";

            for (var i = 0; i < llavePublica.Length; i++)
            {
                llave += llavePublica[i];
            }
            return llave;
        }

        private void btnImportarTDES_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileBrowser = new OpenFileDialog();
            // fileBrowser.InitialDirectory = "C:\\Users\\Jaime\\Desktop";
            fileBrowser.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fileBrowser.Filter = "XML Files|*.xml";
            fileBrowser.RestoreDirectory = true;
            fileBrowser.ShowDialog();


            XmlDocument doc = new XmlDocument();

            doc.Load(fileBrowser.OpenFile());

            this.llave1 = doc.GetElementsByTagName("tdes1").Item(0).InnerText;
            this.llave2 = doc.GetElementsByTagName("tdes2").Item(0).InnerText;
            this.llave3 = doc.GetElementsByTagName("tdes3").Item(0).InnerText;
            this.iv = doc.GetElementsByTagName("iv").Item(0).InnerText;
            this.txtLlaveTDES.Text = this.llave1 + this.llave2 + this.llave3;
            
            this.btnDesencriptarTDES.Enabled = true;
        }

        public void DesencriptarTDES()
        {
            var descencriptador = new RSA.Encriptador();
            this.l1 = descencriptador.Desencriptar(this.llave1, this.llavePrivadaRSA);
            this.l2 = descencriptador.Desencriptar(this.llave2, this.llavePrivadaRSA);
            this.l3 = descencriptador.Desencriptar(this.llave3, this.llavePrivadaRSA);
            this.iv2 = descencriptador.Desencriptar(this.iv, this.llavePrivadaRSA);
            this.txtTDESDesencriptado.Text = this.l1 + this.l2 + this.l3;

            
        }

        private void btnDesencriptarTDES_Click(object sender, EventArgs e)
        {
            this.DesencriptarTDES();
            this.getTDESKey();

        }

        private void getTDESKey()
        {
            var conversor = new Conversores.HexByteArray();
            var llave1 = conversor.StringToByteArray(this.l1);
            var llave2 = conversor.StringToByteArray(this.l2);
            var llave3 = conversor.StringToByteArray(this.l3);

            //var l1= llave1.Concat(llave2).ToArray();
            this.llaveTDES = llave1.Concat(llave2).Concat(llave3).ToArray();       
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            var conversor = new Conversores.HexByteArray();
            var iv = conversor.StringToByteArray(this.iv2);
            var tdesEncriptor = new TDES.TDESCript();
            var textoEncriptado = tdesEncriptor.Encriptar(this.txtTextoEncriptar.Text, this.llaveTDES, iv);
            this.txtTextoEncriptado.Text = conversor.ByteArrayToHex(textoEncriptado);
        }

        private void btnExportarTextoEncriptado_Click(object sender, EventArgs e)
        {

            var doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "UTF-8", null));
            XmlNode nodo = doc.CreateElement("textoe");
            //this.getBytes(this.llavePublica);
            XmlElement root = doc.CreateElement("root");
            nodo.InnerXml = (this.txtTextoEncriptado.Text);
            root.AppendChild(nodo);
            doc.AppendChild(root);
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "XML-File | *.xml";
            if (save.ShowDialog() == DialogResult.OK)
            {
                doc.Save(save.FileName);
                MessageBox.Show("Has guardado el fichero", "Texto Encriptado");
            }
        }

        private void EsclavoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
