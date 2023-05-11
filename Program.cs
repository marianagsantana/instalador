namespace Instalador
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Width = 400;
            form.Height = 400;
            form.Text = "Instalador";
            
            Label label = new Label();
            label.Text = "Digite o seu nome";
            label.Location = new Point(10, 10);
            label.Width = 200;
            label.Height = 20;

            TextBox textBox = new TextBox();
            textBox.Location = new Point(10, 30);
            textBox.Width = 200;
            textBox.Height = 20;

            Button button = new Button();
            button.Text = "Olá";
            button.Location = new Point(10, 50);
            button.Width = 200;
            button.Height = 20;
            button.Click += delegate
            {
                Form form2 = new Form();
                form2.Width = 400;
                form2.Height = 400;
                form2.Text = "Instalador";

                Label label2 = new Label();
                label2.Text = "Olá " + textBox.Text;
                label2.Location = new Point(10, 10);
                label2.Width = 200;
                label2.Height = 20;

                Button button2 = new Button();
                button2.Text = "Ok";
                button2.Location = new Point(10, 50);
                button2.Width = 200;
                button2.Height = 20;
                button2.Click += delegate
                {
                    form2.Close();
                };

                form2.Controls.Add(label2);
                form2.Controls.Add(button2);
                form2.ShowDialog();
            };

            Button button3 = new Button();
            button3.Text = "Sair";
            button3.Location = new Point(10, 70);
            button3.Width = 200;
            button3.Height = 20;
            button3.Click += delegate
            {
                form.Close();
            };

            form.Controls.Add(label);
            form.Controls.Add(textBox);
            form.Controls.Add(button);
            form.Controls.Add(button3);
            form.ShowDialog();
        }
    }
}