using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text;
using System.Media;
using System.Drawing;



namespace Lab16
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
          
        }

        SoundPlayer player = new SoundPlayer();
        SqlConnection sqlConnection;


        private async void User_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet5.Faculty". При необходимости она может быть перемещена или удалена.
            this.facultyTableAdapter.Fill(this.databaseDataSet5.Faculty);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet5.GuideIsp". При необходимости она может быть перемещена или удалена.
            this.guideIspTableAdapter.Fill(this.databaseDataSet5.GuideIsp);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet5.GuideDiscip". При необходимости она может быть перемещена или удалена.
            this.guideDiscipTableAdapter.Fill(this.databaseDataSet5.GuideDiscip);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet5.Grouup". При необходимости она может быть перемещена или удалена.
            this.grouupTableAdapter.Fill(this.databaseDataSet5.Grouup);
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Артём\source\repos\Lab16\Lab16\Database.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();


          



            dataGridView7.DataSource = null;
            dataGridView7.AllowUserToAddRows = true;
            string helper7 = $"SELECT StudentCode,DateBorn,Surname,Name,Patronymic,Gender.GenderName,Grouup.NameGroup" +
                 $" from [Student] JOIN Gender on Gender_M=ID_Gender JOIN Grouup on Groupp=ID_groups " +
                 $"where ID_groups='{comboBox2.SelectedValue}' ";
            SqlDataAdapter dataAdapter7 = new SqlDataAdapter(helper7, sqlConnection);
            DataSet dataSet7 = new DataSet();
            dataAdapter7.Fill(dataSet7);
            dataGridView7.DataSource = dataSet7.Tables[0];
            dataGridView7.AllowUserToAddRows = false;

            /*
            string helper9 = $"select Surname,Name,Patronymic,StudentCode From Student where ID_student " +
           $"in(select studentP From Discipline where NameDis in " +
           $"(select NameDis From Discipline where NameDis='{comboBox17.SelectedValue}' " +
           $"and ID_discipline in (select Discip From Test where Test.NameIsp=" +
           $"(select ChallengeID From GuideIsp where ChallengeName='{comboBox12.SelectedValue}') and DateofDeliv='{textBox3.Text}')))";
            */
            dataGridView9.DataSource = null;
            dataGridView9.AllowUserToAddRows = true;
            string helper9 = $"select Surname,Name,Patronymic,StudentCode From Student where ID_student " +
                $"in(select studentP From Discipline where NameDis in " +
                $"(select NameDis From Discipline where NameDis={comboBox17.SelectedValue} " +
                $"and ID_discipline in (select Discip From Test where Test.NameIsp=" +
                $"(select ChallengeID From GuideIsp where ChallengeName='{comboBox12.SelectedValue}') and DateofDeliv='{textBox3.Text}')))";
            SqlDataAdapter dataAdapter9 = new SqlDataAdapter(helper9, sqlConnection);
            DataSet dataSet9 = new DataSet();
            dataAdapter9.Fill(dataSet9);
            dataGridView9.DataSource = dataSet9.Tables[0];
            dataGridView9.AllowUserToAddRows = false;

            dataGridView10.DataSource = null;
            dataGridView10.AllowUserToAddRows = true;

            string helper10 = $" select Surname, Name, Patronymic, StudentCode,count(*) as Retakes from " +
                $"(select studentp,NameDis from (select discip from " +
                $"(select ID_challenge, Nameisp, Discip, Dateofdeliv from Peresdacha join Test on TestCh=ID_challenge) " +
                $"as T1 where DateofDeliv = '{textBox22.Text}' " +
                $"and NameIsp = (select ChallengeID From GuideIsp where ChallengeName = 'Exam')) " +
                $"as T2 join discipline on id_discipline=discip) as T3 join student on" +
                $" id_student=StudentP where NameDis={comboBox30.SelectedValue} group by Surname, Name, Patronymic, StudentCode ";

            SqlDataAdapter dataAdapter10 = new SqlDataAdapter(helper10, sqlConnection);
            DataSet dataSet10 = new DataSet();
            dataAdapter10.Fill(dataSet10);
            dataGridView10.DataSource = dataSet10.Tables[0];
            dataGridView10.AllowUserToAddRows = false;

            dataGridView11.DataSource = null;
            dataGridView11.AllowUserToAddRows = true;
            string helper11 = "((select Surname, Name, Patronymic, StudentCode From Student where ID_student in (select studentP From Discipline where ID_discipline in (select Discip From Test)) except select Surname, Name, Patronymic, StudentCode From Student where ID_student in (select studentP From Discipline where ID_discipline in (select Discip From Test where Result=3 or Result=4 or Result=6 ) ))) union ( (select Surname, Name, Patronymic, StudentCode From Student where ID_student in (select studentP From Discipline where ID_discipline in (select Discip From Test where ID_challenge in( select TestCh from Peresdacha)))) except (select Surname, Name, Patronymic, StudentCode From Student where ID_student in (select studentP From Discipline where ID_discipline in (select Discip From Test where ID_challenge in( select TestCh from Peresdacha where NewRes=3 or NewRes=4 or NewRes=6 ))))) ";
            SqlDataAdapter dataAdapter11 = new SqlDataAdapter(helper11, sqlConnection);
            DataSet dataSet11 = new DataSet();
            dataAdapter11.Fill(dataSet11);
            dataGridView11.DataSource = dataSet11.Tables[0];
            dataGridView11.AllowUserToAddRows = false;

            dataGridView12.DataSource = null;
            dataGridView12.AllowUserToAddRows = true;
            string helper12 = $" select ID_student,Groupp,StudentCode,DateBorn,Surname,NAME,Patronymic,GenderName from student,Gender where  ID_Gender=Gender_M AND Gender_M=1 AND DATENAME(year,DateBorn )='{textBox23.Text}'";
            SqlDataAdapter dataAdapter12 = new SqlDataAdapter(helper12, sqlConnection);
            DataSet dataSet12 = new DataSet();
            dataAdapter12.Fill(dataSet12);
            dataGridView12.DataSource = dataSet12.Tables[0];
            dataGridView12.AllowUserToAddRows = false;

            dataGridView13.DataSource = null;
            dataGridView13.AllowUserToAddRows = true;
            string helper13 = $"select NameGuideDisp from GuideDiscip where DispID in( select NameDis from Discipline where ID_discipline in( (select ID_discipline from Discipline where StudentP in (select ID_student from Student where Groupp in (select ID_groups From Grouup where Special in (select ID_specialty from Specialization where Facul in (select ID_Faculty from Faculty where ID_Faculty= {comboBox15.SelectedValue})))))))";
            SqlDataAdapter dataAdapter13 = new SqlDataAdapter(helper13, sqlConnection);
            DataSet dataSet13 = new DataSet();
            dataAdapter13.Fill(dataSet13);
            dataGridView13.DataSource = dataSet13.Tables[0];
            dataGridView13.AllowUserToAddRows = false;


            dataGridView14.DataSource = null;
            dataGridView14.AllowUserToAddRows = true;
            string helper14 = $"Select NameGroup,Surname,Name,Patronymic,StudentCode,GenderName From Student,Gender,Grouup " +
                $" where ID_Gender=Gender_M AND ID_groups=Groupp AND Groupp " +
                $"in (select ID_groups From Grouup where Special in" +
                $" (select ID_specialty  from Specialization where Facul in (select ID_Faculty from Faculty where ID_Faculty={comboBox14.SelectedValue})))";
            SqlDataAdapter dataAdapter14 = new SqlDataAdapter(helper14, sqlConnection);
            DataSet dataSet14 = new DataSet();
            dataAdapter14.Fill(dataSet14);
            dataGridView14.DataSource = dataSet14.Tables[0];
            dataGridView14.AllowUserToAddRows = false;

            try
            {
                dataGridView15.DataSource = null;
                dataGridView15.AllowUserToAddRows = true;
                string helper15 = $"select NameGuideDisp from GuideDiscip where DispID in(select NameDis From Discipline where StudentP={comboBox18.SelectedValue} AND  ID_discipline in (select Discip from Test where NameIsp=2 AND DateofDeliv between '{textBox24.Text}' And '{textBox44.Text}'))";
                     //string helper15 = $"select NameGuideDisp from GuideDiscip where DispID in( select NameIsp from Test where NameIsp=2 and Discip in (select ID_discipline from Discipline where StudentP in(Select ID_student from Student where ID_student={comboBox18.SelectedValue} )) AND DateofDeliv between '{textBox24.Text}' And '{textBox44.Text}' )";

                SqlDataAdapter dataAdapter15 = new SqlDataAdapter(helper15, sqlConnection);
                DataSet dataSet15 = new DataSet();
                dataAdapter15.Fill(dataSet15);
                dataGridView15.DataSource = dataSet15.Tables[0];
                dataGridView15.AllowUserToAddRows = false;
            }
            catch
            {

            }


           

            string queryString18 = "SELECT ID_student,Surname+' ' +NAME + ' '+ Patronymic+' '+StudentCode+ ' ' AS Description FROM [Student],[Grouup] where Groupp=ID_groups";//дисциплина студенты
            SqlCommand cmd18 = new SqlCommand(queryString18, sqlConnection);
            DataTable tbl18 = new DataTable();
            SqlDataAdapter da8 = new SqlDataAdapter(cmd18);
            da8.Fill(tbl18);
            this.comboBox18.DataSource = tbl18;
            this.comboBox18.DisplayMember = "Description";// столбец для отображения

            this.comboBox18.ValueMember = "ID_student";//столбец с id
            this.comboBox18.SelectedIndex = -1;




           




        }

        private async void  обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           






            dataGridView7.DataSource = null;
            dataGridView7.AllowUserToAddRows = true;
            string helper7 = $"SELECT StudentCode,DateBorn,Surname,Name,Patronymic,Gender.GenderName,Grouup.NameGroup" +
                 $" from [Student] JOIN Gender on Gender_M=ID_Gender JOIN Grouup on Groupp=ID_groups " +
                 $"where ID_groups='{comboBox2.SelectedValue}' ";
            SqlDataAdapter dataAdapter7 = new SqlDataAdapter(helper7, sqlConnection);
            DataSet dataSet7 = new DataSet();
            dataAdapter7.Fill(dataSet7);
            dataGridView7.DataSource = dataSet7.Tables[0];
            dataGridView7.AllowUserToAddRows = false;

            /*
            string helper9 = $"select Surname,Name,Patronymic,StudentCode From Student where ID_student " +
           $"in(select studentP From Discipline where NameDis in " +
           $"(select NameDis From Discipline where NameDis='{comboBox17.SelectedValue}' " +
           $"and ID_discipline in (select Discip From Test where Test.NameIsp=" +
           $"(select ChallengeID From GuideIsp where ChallengeName='{comboBox12.SelectedValue}') and DateofDeliv='{textBox3.Text}')))";
            */
            dataGridView9.DataSource = null;
            dataGridView9.AllowUserToAddRows = true;
            string helper9 = $"select Surname,Name,Patronymic,StudentCode From Student where ID_student " +
                $"in(select studentP From Discipline where NameDis in " +
                $"(select NameDis From Discipline where NameDis={comboBox17.SelectedValue} " +
                $"and ID_discipline in (select Discip From Test where Test.NameIsp=" +
                $"(select ChallengeID From GuideIsp where ChallengeName='{comboBox12.SelectedValue}') and DateofDeliv='{textBox3.Text}')))";
            SqlDataAdapter dataAdapter9 = new SqlDataAdapter(helper9, sqlConnection);
            DataSet dataSet9 = new DataSet();
            dataAdapter9.Fill(dataSet9);
            dataGridView9.DataSource = dataSet9.Tables[0];
            dataGridView9.AllowUserToAddRows = false;

            dataGridView10.DataSource = null;
            dataGridView10.AllowUserToAddRows = true;

            string helper10 = $" select Surname, Name, Patronymic, StudentCode,count(*) as Retakes from " +
                $"(select studentp,NameDis from (select discip from " +
                $"(select ID_challenge, Nameisp, Discip, Dateofdeliv from Peresdacha join Test on TestCh=ID_challenge) " +
                $"as T1 where DateofDeliv = '{textBox22.Text}' " +
                $"and NameIsp = (select ChallengeID From GuideIsp where ChallengeName = 'Exam')) " +
                $"as T2 join discipline on id_discipline=discip) as T3 join student on" +
                $" id_student=StudentP where NameDis={comboBox30.SelectedValue} group by Surname, Name, Patronymic, StudentCode ";

            SqlDataAdapter dataAdapter10 = new SqlDataAdapter(helper10, sqlConnection);
            DataSet dataSet10 = new DataSet();
            dataAdapter10.Fill(dataSet10);
            dataGridView10.DataSource = dataSet10.Tables[0];
            dataGridView10.AllowUserToAddRows = false;

            dataGridView11.DataSource = null;
            dataGridView11.AllowUserToAddRows = true;
            string helper11 = "((select Surname, Name, Patronymic, StudentCode From Student where ID_student in (select studentP From Discipline where ID_discipline in (select Discip From Test)) except select Surname, Name, Patronymic, StudentCode From Student where ID_student in (select studentP From Discipline where ID_discipline in (select Discip From Test where Result=3 or Result=4 or Result=6 ) ))) union ( (select Surname, Name, Patronymic, StudentCode From Student where ID_student in (select studentP From Discipline where ID_discipline in (select Discip From Test where ID_challenge in( select TestCh from Peresdacha)))) except (select Surname, Name, Patronymic, StudentCode From Student where ID_student in (select studentP From Discipline where ID_discipline in (select Discip From Test where ID_challenge in( select TestCh from Peresdacha where NewRes=3 or NewRes=4 or NewRes=6 ))))) ";
            SqlDataAdapter dataAdapter11 = new SqlDataAdapter(helper11, sqlConnection);
            DataSet dataSet11 = new DataSet();
            dataAdapter11.Fill(dataSet11);
            dataGridView11.DataSource = dataSet11.Tables[0];
            dataGridView11.AllowUserToAddRows = false;

            dataGridView12.DataSource = null;
            dataGridView12.AllowUserToAddRows = true;
            string helper12 = $" select ID_student,Groupp,StudentCode,DateBorn,Surname,NAME,Patronymic,GenderName from student,Gender where  ID_Gender=Gender_M AND Gender_M=1 AND DATENAME(year,DateBorn )='{textBox23.Text}'";
            SqlDataAdapter dataAdapter12 = new SqlDataAdapter(helper12, sqlConnection);
            DataSet dataSet12 = new DataSet();
            dataAdapter12.Fill(dataSet12);
            dataGridView12.DataSource = dataSet12.Tables[0];
            dataGridView12.AllowUserToAddRows = false;

            dataGridView13.DataSource = null;
            dataGridView13.AllowUserToAddRows = true;
            string helper13 = $"select NameGuideDisp from GuideDiscip where DispID in( select NameDis from Discipline where ID_discipline in( (select ID_discipline from Discipline where StudentP in (select ID_student from Student where Groupp in (select ID_groups From Grouup where Special in (select ID_specialty from Specialization where Facul in (select ID_Faculty from Faculty where ID_Faculty= {comboBox15.SelectedValue})))))))";
            SqlDataAdapter dataAdapter13 = new SqlDataAdapter(helper13, sqlConnection);
            DataSet dataSet13 = new DataSet();
            dataAdapter13.Fill(dataSet13);
            dataGridView13.DataSource = dataSet13.Tables[0];
            dataGridView13.AllowUserToAddRows = false;


            dataGridView14.DataSource = null;
            dataGridView14.AllowUserToAddRows = true;
            string helper14 = $"Select NameGroup,Surname,Name,Patronymic,StudentCode,GenderName From Student,Gender,Grouup " +
                $" where ID_Gender=Gender_M AND ID_groups=Groupp AND Groupp " +
                $"in (select ID_groups From Grouup where Special in" +
                $" (select ID_specialty  from Specialization where Facul in (select ID_Faculty from Faculty where ID_Faculty={comboBox14.SelectedValue})))";
            SqlDataAdapter dataAdapter14 = new SqlDataAdapter(helper14, sqlConnection);
            DataSet dataSet14 = new DataSet();
            dataAdapter14.Fill(dataSet14);
            dataGridView14.DataSource = dataSet14.Tables[0];
            dataGridView14.AllowUserToAddRows = false;

            try
            {
                dataGridView15.DataSource = null;
                dataGridView15.AllowUserToAddRows = true;
                // string helper15 = $"select NameGuideDisp from GuideDiscip where DispID in( select NameIsp from Test where NameIsp=2 and Discip in (select ID_discipline from Discipline where StudentP in(Select ID_student from Student where ID_student={comboBox18.SelectedValue} )) AND DateofDeliv between '{textBox24.Text}' And '{textBox44.Text}' )";
                string helper15 = $"select NameGuideDisp from GuideDiscip where DispID in(select NameDis From Discipline where StudentP={comboBox18.SelectedValue} AND  ID_discipline in (select Discip from Test where NameIsp=2 AND DateofDeliv between '{textBox24.Text}' And '{textBox44.Text}'))";
                SqlDataAdapter dataAdapter15 = new SqlDataAdapter(helper15, sqlConnection);
                DataSet dataSet15 = new DataSet();
                dataAdapter15.Fill(dataSet15);
                dataGridView15.DataSource = dataSet15.Tables[0];
                dataGridView15.AllowUserToAddRows = false;
            }
            catch
            {

            }



            string queryString18 = "SELECT ID_student,Surname+' ' +NAME + ' '+ Patronymic+' '+StudentCode+ ' ' AS Description FROM [Student],[Grouup] where Groupp=ID_groups";//дисциплина студенты
            SqlCommand cmd18 = new SqlCommand(queryString18, sqlConnection);
            DataTable tbl18 = new DataTable();
            SqlDataAdapter da8 = new SqlDataAdapter(cmd18);
            da8.Fill(tbl18);
            this.comboBox18.DataSource = tbl18;
            this.comboBox18.DisplayMember = "Description";// столбец для отображения

            this.comboBox18.ValueMember = "ID_student";//столбец с id
            this.comboBox18.SelectedIndex = -1;


           

          


            string queryString3 = "SELECT [ID_Faculty] AS Helper, [NameFaculty] FROM [Faculty] ";//дисциплина студенты
            SqlCommand cmd3 = new SqlCommand(queryString3, sqlConnection);
            DataTable tbl3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);


            



           
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Создайте базу данных Учет успеваемости студентов, разработайте формы ввода, корректировки и просмотра данных.");
            sb.AppendLine("В университете обучаются студенты разных специальностей на нескольких различных факультетах. Каждая специальность относится только к одному факультету, но на факультете несколько специальностей. На каждой специальности обучается много студентов в нескольких группах. Специальность может иметь несколько групп, а может и одну. Студенты изучают несколько дисциплин и проходят испытания (зачеты, экзамены, курсовые и контрольные работы). Результаты испытаний заносятся в базу данных.");
            sb.AppendLine("Необходимо разработать систему для решения с использованием информации базы данных следующих задач:");
            sb.AppendLine("1) получите списки студентов указанной группы;");
            sb.AppendLine("2) получите списки студентов, сдававших указанные экзамены;");
            sb.AppendLine("3) получите списки студентов, пересдававших указанный экзамен, а также количество пересдач по каждому пересдававшему;");
            sb.AppendLine("4) получите списки назначенных на стипендию;");
            sb.AppendLine("5) получите списки предметов, которые сдаются на указанном факультете;");
            sb.AppendLine("6) получите списки для военкомата (юноши указанного года рождения);");
            sb.AppendLine("7) получите списки студентов и их групп указанного факультета;");
            sb.AppendLine("8) получите список предметов, сдававшихся указанным студентом в указанный период.");

            MessageBox.Show(sb.ToString());
        }

        private void touchInTheNightSilentCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();

         

            player.SoundLocation = "Silent_Circle_-_Touch_in_the_Night_61645133.wav";


            player.Load();
            player.PlayLooping();
        }

        private void iWantToBreakFreeQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            player.SoundLocation = "Queen_-_I_Want_To_Break_Free_59814127.wav";
            player.Load();
            player.PlayLooping();
        }

        private void wastedYearsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            player.SoundLocation = "Iron_Maiden_-_Wasted_Years_47955118.wav";
            player.Load();
            player.PlayLooping();
        }

        private void rockTheNightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            player.SoundLocation = "Europe_-_Rock_the_Night_47852089.wav";
            player.Load();
            player.PlayLooping();
        }

        private void limpBizkitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            player.SoundLocation = "Limp_Bizkit_-_Take_A_Look_Around_47872527.wav";
            player.Load();
            player.PlayLooping();
        }

        private void стопToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Password newForm = new Password();

            newForm.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
