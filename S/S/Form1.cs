namespace S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pregunta.Parent = pictureBox1;
            TQM.Parent = pictureBox2;
            TQM2.Parent = pictureBox2;
            panel2.Hide();
            botonSi.TabStop = false;
            botonNo.TabStop = false;
        }

        public void moverBoton()
        {
            Random r = new Random();
            int x = r.Next(0,this.Width - botonNo.Width);
            int y = r.Next(0, this.Height - botonNo.Height);
            botonNo.Location = new Point(x, y);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //BOTON SI
            panel2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BOTON NO
        }

        private void Pregunta_Click(object sender, EventArgs e)
        {
            //PREGUNTA
        }

        private void botonNo_MouseMove(object sender, MouseEventArgs e)
        {
            //MOVIMIENTO DE BOTON NO
            moverBoton();
            if(botonNo.Location == botonSi.Location || botonNo.Location == Pregunta.Location)
            {
                moverBoton();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //BOTON ACEPTAR
            Application.Exit();
        }
    }
}