using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilari_Odev7
{

    public partial class Form1 : Form
    {
        Node root = new Node(0, null, null);

        //Tree agac = new Tree();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle(root, Convert.ToInt32(textBox1.Text));
            MessageBox.Show("Eklendi");
            listBox1.Items.Add(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
        }
        public void Ekle(Node root, int deger) //////EKLE FONKSİYONU
        {
            Node yeni = new Node(deger, null, null);
            if (root.deger == 0)
            {
                root.deger = deger;
            }
            else
            {
                Node aktif = root;
                Node parent;
                while (true)
                {
                    parent = aktif;
                    if (deger < aktif.deger)
                    {
                        aktif = aktif.leftChild;
                        if (aktif == null)
                        {
                            parent.leftChild = yeni;
                            break;
                        }
                    }
                    else
                    {
                        aktif = aktif.rightChild;
                        if (aktif == null)
                        {
                            parent.rightChild = yeni;
                            return;
                        }
                    }
                }
            }
        }
        private void btnTraverse_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            LevelOrderTraverse(root);
        }
        public void LevelOrderTraverse(Node root)////LEVEL ORDER TRAVERSE FONKSİYONLARI
        {
            for (int i = 1; i <= Level(root); i++)
            {
                LeveliYazdir(root, i);
            }
        }
        public int Level(Node root)
        {
            if (root == null)
                return 0;
            else
            {
                int solLevel = Level(root.leftChild);
                int sagLevel = Level(root.rightChild);

                if (sagLevel > solLevel)
                    return (sagLevel + 1);
                else
                    return (solLevel + 1);
            }
        }

        public void LeveliYazdir(Node root, int i)
        {
            if (root == null)
                return;
            if (i == 1)
            {
                listBox1.Items.Add(root.deger);
            }
            else if (i > 1)
            {
                LeveliYazdir(root.leftChild, i - 1);
                LeveliYazdir(root.rightChild, i - 1);
            }
        }
        private void btn_Max_Click(object sender, EventArgs e)
        {
            label1.Text = max(root).deger.ToString();
        }
        public Node max(Node root) //MAX DEĞER FONKSİYONU
        {
            Node aktif;
            aktif = root;
            while (aktif.rightChild != null)
                aktif = aktif.rightChild;
            return aktif;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            label2.Text = min(root).deger.ToString();
        }
        public Node min(Node root) ////MIN DEĞER FONKSİYONU
        {
            Node aktif;
            aktif = root;
            while (aktif.leftChild != null)
                aktif = aktif.leftChild;
            return aktif;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Sil(root, Convert.ToInt32(textBox2.Text)) != null)
                MessageBox.Show("Silindi");
            textBox2.Clear();
        }
        public Node Sil(Node root, int deger) ///ISTENİLENİ SİLME FONKSİYONU
        {
            Node aktif = root;
            Node parent = null;
            if (Bul(aktif, deger) == null)
            {
                MessageBox.Show("Sayı Bulunamadı");
                return null;
            }
            else
            {
                while (aktif != null && aktif.deger != deger)
                {
                    parent = aktif;
                    if (deger < aktif.deger)
                        aktif = aktif.leftChild;
                    else
                        aktif = aktif.rightChild;
                }
                if (aktif == null)
                    return root;
                if (aktif.leftChild == null && aktif.rightChild == null)
                {
                    if (aktif != root)
                    {
                        if (parent.leftChild == aktif)
                            parent.leftChild = null;
                        else
                            parent.rightChild = null;
                    }
                    else
                        root = null;
                }
                else if (aktif.leftChild != null && aktif.rightChild != null)
                {
                    Node gecici = min(aktif.rightChild);
                    Sil(root, gecici.deger);
                    aktif.deger = gecici.deger;
                }
                else
                {

                    Node child;
                    if (aktif.leftChild != null)
                        child = aktif.leftChild;
                    else
                        child = aktif.rightChild;
                    if (aktif != root)
                    {
                        if (aktif == parent.leftChild)
                            parent.leftChild = child;
                        else
                            parent.rightChild = child;
                    }
                    else
                        root = child;
                }

                return root;
            }
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            HepsiniSil(root);

        }
        public void HepsiniSil(Node root) //HEPSİNİ SİLME FONKSİYONU
        {
            if (root.leftChild != null)
                HepsiniSil(root.leftChild);
            if (root.rightChild != null)
                HepsiniSil(root.rightChild);
            root.leftChild = null;
            root.rightChild = null;
            root.deger = 0;
        }

        private void btnSayiBul_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox3.Text);
            if (Bul(root, sayi) == null)
                label4.Text = "Sonuç: Sayı bulunamadı";
            else
                label4.Text = "Sonuç: Sayı bulundu";
        }
        public Node Bul(Node root, int deger) //SAYIYI BULMA FONKSİYONU
        {
            Node aktif = root;
            while (aktif.deger != deger)
            {
                if (deger < aktif.deger)
                    aktif = aktif.leftChild;
                else
                    aktif = aktif.rightChild;
                if (aktif == null)
                    return null;
            }
            return aktif;
        }

        private void btn_TraversePre_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Pre(root);
        }

        private void btnTraversePost_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Post(root);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            In(root);
        }
        void Pre(Node root)
        {
            listBox1.Items.Add(root.deger);
            if (root.leftChild != null)
            {
                Pre(root.leftChild);
            }
            if (root.rightChild != null)
            {
                Pre(root.rightChild);
            }
        }

        void Post(Node root)
        {
            if (root.leftChild != null)
            {
                Pre(root.leftChild);
            }
            if (root.rightChild != null)
            {
                Pre(root.rightChild);
            }
            listBox1.Items.Add(root.deger);
        }

        void In(Node root)
        {
            if (root.leftChild != null)
            {
                Pre(root.leftChild);
            }

            listBox1.Items.Add(root.deger);

            if (root.rightChild != null)
            {
                Pre(root.rightChild);
            }
        }
    }
    public class Node
    {
        public int deger;
        public Node leftChild, rightChild;

        public Node(int deger, Node leftChild, Node rightChild)
        {
            this.deger = deger;
            this.leftChild = leftChild;
            this.rightChild = rightChild;
        }
    }
    /*public class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }

    }*/
}
