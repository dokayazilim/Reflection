using System.Reflection;

namespace ReflectionWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_object.Text))
            {
                txt_object.BackColor = Color.White;
                Type T = Type.GetType(txt_object.Text);
                if (T != null)
                {
                    CTORS(T);
                    PROPS(T);
                    METH(T);
                }
                else 
                {
                    Console.WriteLine($"{txt_object.Text} Aramýþ olduðunuz sýnýf bulunamadý","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bilgi almak istediðiniz sýnýfýn tam adýný giriniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_object.BackColor = Color.Yellow;
            }
        }

        private void METH(Type T)
        {
            lst_meths.Items.Clear();
            MethodInfo[] RV = T.GetMethods();
            foreach (var item in RV) 
            {
                lst_meths.Items.Add($"{item.ReturnType.Name} {item.Name}");
            }
        }

        private void PROPS(Type T)
        {
            lst_props.Items.Clear();
            PropertyInfo[] RV = T.GetProperties();
            foreach (var item in RV) 
            {
                lst_props.Items.Add(item.Name);
            }
        }

        private void CTORS(Type T) 
        {
            lst_ctors.Items.Clear();    
            ConstructorInfo[] RV = T.GetConstructors();
            foreach (var item in RV) 
            {
                lst_ctors.Items.Add(item.ToString());
            }
        }
    }
}