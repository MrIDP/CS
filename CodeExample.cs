using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectOfCourse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Visual Studio 2017\Projects\ProjectOfCourse\База данных программного обеспечения.mdf;Integrated Security=True";
        byte type = 1;
        const string tab = "      ", tab1 = "          ";
        private async void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных_программного_обеспеченияDataSet.Заявки". При необходимости она может быть перемещена или удалена.
            this.заявкиTableAdapter.Fill(this.база_данных_программного_обеспеченияDataSet.Заявки);
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            Вкладки.SelectedIndex = 0;
            ОбновитьПК("SELECT * FROM [ПК]");
        }

        public async void ОбновитьПК(string Запрос)
        {
            Вывод.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand(Запрос, sqlConnection);
            Вывод.Items.Add("ID ПК" + tab + "IP" + tab + "MAC" + tab + "Название" + tab + "CPU" + tab + "ОЗУ" + tab + "HDD" + tab + "Видеокарта" + tab + "Категория" + tab + "ПО" + tab + "Тип" + tab + "Модель" + tab + "Состояние" + tab + "Интернет" + tab + "Аудитория" + tab + "Номер задания" + tab + "Тип помещения" + tab + "Инвентарный номер" + tab + "Дополнительная информация");
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    Вывод.Items.Add(Convert.ToString(sqlReader["ID ПК"]) + tab1 +
                        Convert.ToString(sqlReader["IP"]) + tab1 +
                        Convert.ToString(sqlReader["MAC"]) + tab1 +
                        Convert.ToString(sqlReader["Название"]) + tab1 +
                        Convert.ToString(sqlReader["CPU"]) + tab1 +
                        Convert.ToString(sqlReader["ОЗУ"]) + tab1 +
                        Convert.ToString(sqlReader["HDD"]) + tab1 +
                        Convert.ToString(sqlReader["Видеокарта"]) + tab1 +
                        Convert.ToString(sqlReader["Категория"]) + tab1 +
                        Convert.ToString(sqlReader["ПО"]) + tab1 +
                        Convert.ToString(sqlReader["Тип"]) + tab1 +
                        Convert.ToString(sqlReader["Модель"]) + tab1 +
                        Convert.ToString(sqlReader["Состояние"]) + tab1 +
                        Convert.ToString(sqlReader["Интернет"]) + tab1 +
                        Convert.ToString(sqlReader["Аудитория"]) + tab1 +
                        Convert.ToString(sqlReader["Номер задания"]) + tab1 +
                        Convert.ToString(sqlReader["Тип помещения"]) + tab1 +
                        Convert.ToString(sqlReader["Инвентарный номер"]) + tab1 +
                        Convert.ToString(sqlReader["Дополнительная информация"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }

            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }
        public async void ОбновитьПО(string Запрос)
        {
            Вывод.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand(Запрос, sqlConnection);
            Вывод.Items.Add("ID ПО" + tab + "Название" + tab + "Тип лицензии" + tab + "Статус лицензии" + tab + "Действие лицензии" + tab + "Дата покупки" + tab + "Дата окончания лицензии" + tab + "Количество лицензий" + tab + "Версия" + tab + "Описание" + tab + "Стоимость" + tab + "Категория" + tab + "Подразделение" + tab + "Обновление" + tab + "Инвентарный номер" + tab + "Рекомендуемые требования" + tab + "Использовано лицензий" + tab + "Лицензионный номер" + tab + "Пароль" + tab + "Язык" + tab + "Осталось лицензий");
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    Вывод.Items.Add(Convert.ToString(sqlReader["ID ПО"]) + tab1 +
                        Convert.ToString(sqlReader["Название"]) + tab1 +
                        Convert.ToString(sqlReader["Тип лицензии"]) + tab1 +
                        Convert.ToString(sqlReader["Статус лицензии"]) + tab1 +
                        Convert.ToString(sqlReader["Действие лицензии"]) + tab1 +
                        Convert.ToString(sqlReader["Дата покупки"]) + tab1 +
                        Convert.ToString(sqlReader["Дата окончания лицензии"]) + tab1 +
                        Convert.ToString(sqlReader["Количество лицензий"]) + tab1 +
                        Convert.ToString(sqlReader["Версия"]) + tab1 +
                        Convert.ToString(sqlReader["Описание"]) + tab1 +
                        Convert.ToString(sqlReader["Стоимость"]) + tab1 +
                        Convert.ToString(sqlReader["Категория"]) + tab1 +
                        Convert.ToString(sqlReader["Подразделение"]) + tab1 +
                        Convert.ToString(sqlReader["Обновление"]) + tab1 +
                        Convert.ToString(sqlReader["Инвентарный номер"]) + tab1 +
                        Convert.ToString(sqlReader["Рекомендуемые требования"]) + tab1 +
                        Convert.ToString(sqlReader["Использовано лицензий"]) + tab1 +
                        Convert.ToString(sqlReader["Лицензионный номер"]) + tab1 +
                        Convert.ToString(sqlReader["Пароль"]) + tab1 +
                        Convert.ToString(sqlReader["Язык"]) + tab1 +
                        Convert.ToString(sqlReader["Осталось лицензий"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }

            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }
        public async void ОбновитьЗаявки(string Запрос)
        {
            Вывод.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand(Запрос, sqlConnection);
            Вывод.Items.Add("ID Заявки" + tab +"ID ПО" + tab + "Описание" + tab + "Заявитель" + tab + "Дата составления" + tab + "Дата выполнения" + tab + "Статус");
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    Вывод.Items.Add(Convert.ToString(sqlReader["ID Заявки"]) + tab1 +
                        Convert.ToString(sqlReader["ID ПО"]) + tab1 +
                        Convert.ToString(sqlReader["Описание"]) + tab1 +
                        Convert.ToString(sqlReader["Заявитель"]) + tab1 +
                        Convert.ToString(sqlReader["Дата составления"]) + tab1 +
                        Convert.ToString(sqlReader["Дата выполнения"]) + tab1 +
                        Convert.ToString(sqlReader["Статус"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }

            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }
        public async void ОбновитьПКПО(string Запрос)
        {
            Вывод.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand(Запрос, sqlConnection);
            Вывод.Items.Add("ID ПК" + tab + "ID ПО");
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    Вывод.Items.Add(Convert.ToString(sqlReader["ID ПК"]) + tab1 +
                        Convert.ToString(sqlReader["ID ПО"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }

            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            sqlConnection.Close();
        }

        private void Вывод_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (type == 1)
                {
                    String text = Вывод.SelectedItem.ToString();
                    string text1 = text;
                    const int max = 19;
                    string[] happy, happyend = new string[max];
                    happy = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int g = 0;
                    foreach (string s in happy)
                    {
                        happyend[g] += s;
                        g += 1;
                        if (g == max) break;
                    }
                    ПКДополнительнаяинформация.Text = happyend[18];
                    ПКИнвентарныйномер.Text = happyend[17];
                    ПКТиппомещения.Text = happyend[16];
                    ПКНомерзадания.Text = happyend[15];
                    ПКАудитория.Text = happyend[14];
                    ПКИнтернет.Text = happyend[13];
                    ПКСостояние.Text = happyend[12];
                    ПКМодель.Text = happyend[11];
                    ПКТип.Text = happyend[10];
                    ПКПО.Text = happyend[9];
                    ПККатегория.Text = happyend[8];
                    ПКВидеокарта.Text = happyend[7];
                    ПКHDD.Text = happyend[6];
                    ПКОЗУ.Text = happyend[5];
                    ПКCPU.Text = happyend[4];
                    ПКНазвание.Text = happyend[3];
                    ПКMAC.Text = happyend[2];
                    ПКIP.Text = happyend[1];
                    ПКIDПК.Text = happyend[0];
                    //ПолеДатаОкончанияРабот.Text = happyend[6] + " " + happyend[7];

                }
                if (type == 2)
                {
                    String text = Вывод.SelectedItem.ToString();
                    string text1 = text;
                    const int max = 23;
                    string[] happy, happyend = new string[max];
                    happy = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int g = 0;
                    foreach (string s in happy)
                    {
                        happyend[g] += s;
                        g += 1;
                        if (g == max) break;
                    }
                    ПООсталосьлицензий.Text = happyend[22];
                    ПОЯзык.Text = happyend[21];
                    ПОПароль.Text = happyend[20];
                    ПОЛицензионныйномер.Text = happyend[19];
                    ПОИспользованолицензий.Text = happyend[18];
                    ПОРекомендуемыетребования.Text = happyend[17];
                    ПОИнвентарныйномер.Text = happyend[16];
                    ПООбновление.Text = happyend[15];
                    ПОПодразделение.Text = happyend[14];
                    ПОКатегория.Text = happyend[13];
                    ПОСтоимость.Text = happyend[12];
                    ПООписание.Text = happyend[11];
                    ПОВерсия.Text = happyend[10];
                    ПОКоличестволицензий.Text = happyend[9];
                    ПОДатаокончаниялицензии.Text = happyend[7] + " " + happyend[8];
                    ПОДатапокупки.Text = happyend[5] + " " + happyend[6];
                    ПОДействиелицензии.Text = happyend[4];
                    ПОСтатуслицензии.Text = happyend[3];
                    ПОТиплицензии.Text = happyend[2];
                    ПОНазвание.Text = happyend[1];
                    ПОIDПО.Text = happyend[0];
                }
                if (type == 3)
                {
                    String text = Вывод.SelectedItem.ToString();
                    string text1 = text;
                    const int max = 9;
                    string[] happy, happyend = new string[max];
                    happy = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int g = 0;
                    foreach (string s in happy)
                    {
                        happyend[g] += s;
                        g += 1;
                        if (g == max) break;
                    }
                    ЗаявкаСтатус.Text = happyend[8];
                    ЗаявкаДатавыполнения.Text = happyend[6] + " " + happyend[7];
                    ЗаявкаДатасоставления.Text = happyend[4] + " " + happyend[5];
                    ЗаявкаЗаявитель.Text = happyend[3];
                    ЗаявкаОписание.Text = happyend[2];
                    ЗаявкаIDПО.Text = happyend[1];
                    ЗаявкаIDЗаявки.Text = happyend[0];
                }
                if (type == 4)
                {
                    String text = Вывод.SelectedItem.ToString();
                    string text1 = text;
                    const int max = 2;
                    string[] happy, happyend = new string[max];
                    happy = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int g = 0;
                    foreach (string s in happy)
                    {
                        happyend[g] += s;
                        g += 1;
                        if (g == max) break;
                    }
                    ПКПОIDПО.Text = happyend[1];
                    ПКПОIDПК.Text = happyend[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ДобавитьПК_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO [ПК] ([ID ПК], IP, MAC, Название, CPU, ОЗУ, HDD, Видеокарта, Категория, ПО, Тип, Модель, Состояние, Интернет, Аудитория, [Номер задания], [Тип помещения], [Инвентарный номер], [Дополнительная информация])VALUES(@IDПК, @IP, @MAC, @Название, @CPU, @ОЗУ, @HDD, @Видеокарта, @Категория, @ПО, @Тип, @Модель, @Состояние, @Интернет, @Аудитория, @Номерзадания, @Типпомещения, @Инвентарныйномер, @Дополнительнаяинформация)", sqlConnection);
                command.Parameters.AddWithValue("IDПК", ПКIDПК.Text);
                command.Parameters.AddWithValue("IP", ПКIP.Text);
                command.Parameters.AddWithValue("MAC", ПКMAC.Text);
                command.Parameters.AddWithValue("Название", ПКНазвание.Text);
                command.Parameters.AddWithValue("CPU", ПКCPU.Text);
                command.Parameters.AddWithValue("ОЗУ", ПКОЗУ.Text);
                command.Parameters.AddWithValue("HDD", ПКHDD.Text);
                command.Parameters.AddWithValue("Видеокарта", ПКВидеокарта.Text);
                command.Parameters.AddWithValue("Категория", ПККатегория.Text);
                command.Parameters.AddWithValue("ПО", ПКПО.Text);
                command.Parameters.AddWithValue("Тип", ПКТип.Text);
                command.Parameters.AddWithValue("Модель", ПКМодель.Text);
                command.Parameters.AddWithValue("Состояние", ПКСостояние.Text);
                command.Parameters.AddWithValue("Интернет", ПКИнтернет.Text);
                command.Parameters.AddWithValue("Аудитория", ПКАудитория.Text);
                command.Parameters.AddWithValue("Номерзадания", ПКНомерзадания.Text);
                command.Parameters.AddWithValue("Типпомещения", ПКТиппомещения.Text);
                command.Parameters.AddWithValue("Инвентарныйномер", ПКИнвентарныйномер.Text);
                command.Parameters.AddWithValue("Дополнительнаяинформация", ПКДополнительнаяинформация.Text);
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }
            ОбновитьПК("SELECT * FROM [ПК]");
        }
        private async void УдалитьПК_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM [ПК] WHERE [ID ПК]=@IDПК", sqlConnection);
                command.Parameters.AddWithValue("IDПК", ПКIDПК.Text);
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }
            ОбновитьПК("SELECT * FROM [ПК]");
        }
        private async void РедактироватьПК_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("UPDATE [ПК] SET [ID ПК]=@IDПК, IP=@IP, MAC=@MAC, Название=@Название, CPU=@CPU, ОЗУ=@ОЗУ, HDD=@HDD, Видеокарта=@Видеокарта, Категория=@Категория, ПО=@ПО, Тип=@Тип, Модель=@Модель, Состояние=@Состояние, Интернет=@Интернет, Аудитория=@Аудитория, [Номер задания]=@Номерзадания, [Тип помещения]=@Типпомещения, [Инвентарный номер]=@Инвентарныйномер, [Дополнительная информация]=@Дополнительнаяинформация WHERE[ID ПК] = @IDПК", sqlConnection);
                command.Parameters.AddWithValue("IDПК", ПКIDПК.Text);
                command.Parameters.AddWithValue("IP", ПКIP.Text);
                command.Parameters.AddWithValue("MAC", ПКMAC.Text);
                command.Parameters.AddWithValue("Название", ПКНазвание.Text);
                command.Parameters.AddWithValue("CPU", ПКCPU.Text);
                command.Parameters.AddWithValue("ОЗУ", ПКОЗУ.Text);
                command.Parameters.AddWithValue("HDD", ПКHDD.Text);
                command.Parameters.AddWithValue("Видеокарта", ПКВидеокарта.Text);
                command.Parameters.AddWithValue("Категория", ПККатегория.Text);
                command.Parameters.AddWithValue("ПО", ПКПО.Text);
                command.Parameters.AddWithValue("Тип", ПКТип.Text);
                command.Parameters.AddWithValue("Модель", ПКМодель.Text);
                command.Parameters.AddWithValue("Состояние", ПКСостояние.Text);
                command.Parameters.AddWithValue("Интернет", ПКИнтернет.Text);
                command.Parameters.AddWithValue("Аудитория", ПКАудитория.Text);
                command.Parameters.AddWithValue("Номерзадания", ПКНомерзадания.Text);
                command.Parameters.AddWithValue("Типпомещения", ПКТиппомещения.Text);
                command.Parameters.AddWithValue("Инвентарныйномер", ПКИнвентарныйномер.Text);
                command.Parameters.AddWithValue("Дополнительнаяинформация", ПКДополнительнаяинформация.Text);
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }
            ОбновитьПК("SELECT * FROM [ПК]");
        }

        private async void ДобавитьПО_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO [ПО] ([ID ПО], Название, [Тип лицензии], [Статус лицензии], [Действие лицензии], [Дата покупки], [Дата окончания лицензии], [Количество лицензий], Версия, Описание, Стоимость, Категория, Подразделение, Обновление, [Инвентарный номер], [Рекомендуемые требования], [Использовано лицензий], [Лицензионный номер], Пароль, Язык, [Осталось лицензий])" +
                    "VALUES(@IDПО, @Название, @Типлицензии, @Статуслицензии, @Действиелицензии, @Датапокупки, " +
                    "@Датаокончаниялицензии, @Количестволицензий, @Версия, @Описание, @Стоимость, @Категория, @Подразделение, @Обновление, @Инвентарныйномер, @Рекомендуемыетребования, @Использованолицензий, @Лицензионныйномер, @Пароль, @Язык, @Осталосьлицензий)", sqlConnection);
                command.Parameters.AddWithValue("IDПО", ПОIDПО.Text);
                command.Parameters.AddWithValue("Название", ПОНазвание.Text);
                command.Parameters.AddWithValue("Типлицензии", ПОТиплицензии.Text);
                command.Parameters.AddWithValue("Статуслицензии", ПОСтатуслицензии.Text);
                command.Parameters.AddWithValue("Действиелицензии", ПОДействиелицензии.Text);
                command.Parameters.AddWithValue("Датапокупки", ПОДатапокупки.Text);
                command.Parameters.AddWithValue("Датаокончаниялицензии", ПОДатаокончаниялицензии.Text);
                command.Parameters.AddWithValue("Количестволицензий", ПОКоличестволицензий.Text);
                command.Parameters.AddWithValue("Версия", ПОВерсия.Text);
                command.Parameters.AddWithValue("Описание", ПООписание.Text);
                command.Parameters.AddWithValue("Стоимость", ПОСтоимость.Text);
                command.Parameters.AddWithValue("Категория", ПОКатегория.Text);
                command.Parameters.AddWithValue("Подразделение", ПОПодразделение.Text);
                command.Parameters.AddWithValue("Обновление", ПООбновление.Text);
                command.Parameters.AddWithValue("Инвентарныйномер", ПОИнвентарныйномер.Text);
                command.Parameters.AddWithValue("Рекомендуемыетребования", ПОРекомендуемыетребования.Text);
                command.Parameters.AddWithValue("Использованолицензий", ПОИспользованолицензий.Text);
                command.Parameters.AddWithValue("Лицензионныйномер", ПОЛицензионныйномер.Text);
                command.Parameters.AddWithValue("Пароль", ПОПароль.Text);
                command.Parameters.AddWithValue("Язык", ПОЯзык.Text);
                command.Parameters.AddWithValue("Осталосьлицензий", ПООсталосьлицензий.Text);
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }
            ОбновитьПО("SELECT * FROM [ПО]");
        }
        private async void УдалитьПО_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM [ПО] WHERE [ID ПО]=@IDПО", sqlConnection);
                command.Parameters.AddWithValue("IDПО", ПОIDПО.Text);
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }
            ОбновитьПО("SELECT * FROM [ПО]");
        }
        private async void РедактироватьПО_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("UPDATE [ПО] SET [ID ПО]=@IDПО, Название=@Название, [Тип лицензии]=@Типлицензии, [Статус лицензии]=@Статуслицензии, [Действие лицензии]=@Действиелицензии, [Дата покупки]=@Датапокупки, [Дата окончания лицензии]=@Датаокончаниялицензии, [Количество лицензий]=@Количестволицензий, Версия=@Версия, Описание=@Описание, Стоимость=@Стоимость, Категория=@Категория, Подразделение=@Подразделение, Обновление=@Обновление, [Инвентарный номер]=@Инвентарныйномер, [Рекомендуемые требования]=@Рекомендуемыетребования, [Использовано лицензий]=@Использованолицензий, [Лицензионный номер]=@Лицензионныйномер, Пароль=@Пароль, Язык=@Язык, [Осталось лицензий]=@Осталосьлицензий WHERE [ID ПО]=@IDПО", sqlConnection);
                command.Parameters.AddWithValue("IDПО", ПОIDПО.Text);
                command.Parameters.AddWithValue("Название", ПОНазвание.Text);
                command.Parameters.AddWithValue("Типлицензии", ПОТиплицензии.Text);
                command.Parameters.AddWithValue("Статуслицензии", ПОСтатуслицензии.Text);
                command.Parameters.AddWithValue("Действиелицензии", ПОДействиелицензии.Text);
                command.Parameters.AddWithValue("Датапокупки", ПОДатапокупки.Text);
                command.Parameters.AddWithValue("Датаокончаниялицензии", ПОДатаокончаниялицензии.Text);
                command.Parameters.AddWithValue("Количестволицензий", ПОКоличестволицензий.Text);
                command.Parameters.AddWithValue("Версия", ПОВерсия.Text);
                command.Parameters.AddWithValue("Описание", ПООписание.Text);
                command.Parameters.AddWithValue("Стоимость", ПОСтоимость.Text);
                command.Parameters.AddWithValue("Категория", ПОКатегория.Text);
                command.Parameters.AddWithValue("Подразделение", ПОПодразделение.Text);
                command.Parameters.AddWithValue("Обновление", ПООбновление.Text);
                command.Parameters.AddWithValue("Инвентарныйномер", ПОИнвентарныйномер.Text);
                command.Parameters.AddWithValue("Рекомендуемыетребования", ПОРекомендуемыетребования.Text);
                command.Parameters.AddWithValue("Использованолицензий", ПОИспользованолицензий.Text);
                command.Parameters.AddWithValue("Лицензионныйномер", ПОЛицензионныйномер.Text);
                command.Parameters.AddWithValue("Пароль", ПОПароль.Text);
                command.Parameters.AddWithValue("Язык", ПОЯзык.Text);
                command.Parameters.AddWithValue("Осталосьлицензий", ПООсталосьлицензий.Text);
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }
            ОбновитьПО("SELECT * FROM [ПО]");
        }

        private async void ДобавитьЗаявку_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO [Заявки] ([ID Заявки], [ID ПО], Описание, Заявитель, [Дата составления], [Дата выполнения], Статус)" +
                    "VALUES(@IDЗаявки, @IDПО, @Описание, @Заявитель, @Датасоставления, @Датавыполнения, @Статус)", sqlConnection);
                command.Parameters.AddWithValue("IDЗаявки", ЗаявкаIDЗаявки.Text);
                command.Parameters.AddWithValue("IDПО", ЗаявкаIDПО.Text);
                command.Parameters.AddWithValue("Описание", ЗаявкаОписание.Text);
                command.Parameters.AddWithValue("Заявитель", ЗаявкаЗаявитель.Text);
                command.Parameters.AddWithValue("Датасоставления", ЗаявкаДатасоставления.Text);
                command.Parameters.AddWithValue("Датавыполнения", ЗаявкаДатавыполнения.Text);
                command.Parameters.AddWithValue("Статус", ЗаявкаСтатус.Text);
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }
            ОбновитьЗаявки("SELECT * FROM [Заявки]");
        }
        private async void УдалитьЗаявку_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM [Заявки] WHERE [ID Заявки]=@IDЗаявки", sqlConnection);
                command.Parameters.AddWithValue("IDЗаявки", ЗаявкаIDЗаявки.Text);
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }
            ОбновитьЗаявки("SELECT * FROM [Заявки]");
        }
        private async void РедактироватьЗаявку_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("UPDATE [Заявки] SET [ID Заявки]=@IDЗаявки, [ID ПО]=@IDПО, Описание=@Описание, Заявитель=@Заявитель, [Дата составления]=@Датасоставления, [Дата выполнения]=@Датавыполнения, Статус=@Статус WHERE [ID Заявки]=@IDЗаявки", sqlConnection);
                command.Parameters.AddWithValue("IDЗаявки", ЗаявкаIDЗаявки.Text);
                command.Parameters.AddWithValue("IDПО", ЗаявкаIDПО.Text);
                command.Parameters.AddWithValue("Описание", ЗаявкаОписание.Text);
                command.Parameters.AddWithValue("Заявитель", ЗаявкаЗаявитель.Text);
                command.Parameters.AddWithValue("Датасоставления", ЗаявкаДатасоставления.Text);
                command.Parameters.AddWithValue("Датавыполнения", ЗаявкаДатавыполнения.Text);
                command.Parameters.AddWithValue("Статус", ЗаявкаСтатус.Text);
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }
            ОбновитьЗаявки("SELECT * FROM [Заявки]");
        }

        private async void СортироватьЗаявкиПоСтатусу_Click(object sender, EventArgs e)
        {
            Вывод.Items.Clear();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("SELECT * FROM [Заявки] WHERE Статус=@Статус", sqlConnection);

            try
            {
                command.Parameters.AddWithValue("Статус", ЗаявкаСтатус.Text);
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    Вывод.Items.Add(Convert.ToString(sqlReader["ID Заявки"]) + tab1 +
                        Convert.ToString(sqlReader["Описание"]) + tab1 +
                        Convert.ToString(sqlReader["Заявитель"]) + tab1 +
                        Convert.ToString(sqlReader["Дата составления"]) + tab1 +
                        Convert.ToString(sqlReader["Дата выполнения"]) + tab1 +
                        Convert.ToString(sqlReader["Статус"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }

            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private async void ПКСортировкаПоСостоянию_Click(object sender, EventArgs e)
        {
            Вывод.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [ПК] WHERE Состояние=@Состояние", sqlConnection);

            try
            {
                command.Parameters.AddWithValue("Состояние", ПКСостояние.Text);
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    Вывод.Items.Add(Convert.ToString(sqlReader["ID ПК"]) + tab1 +
                        Convert.ToString(sqlReader["IP"]) + tab1 +
                        Convert.ToString(sqlReader["MAC"]) + tab1 +
                        Convert.ToString(sqlReader["Название"]) + tab1 +
                        Convert.ToString(sqlReader["CPU"]) + tab1 +
                        Convert.ToString(sqlReader["ОЗУ"]) + tab1 +
                        Convert.ToString(sqlReader["HDD"]) + tab1 +
                        Convert.ToString(sqlReader["Видеокарта"]) + tab1 +
                        Convert.ToString(sqlReader["Категория"]) + tab1 +
                        Convert.ToString(sqlReader["ПО"]) + tab1 +
                        Convert.ToString(sqlReader["Тип"]) + tab1 +
                        Convert.ToString(sqlReader["Модель"]) + tab1 +
                        Convert.ToString(sqlReader["Состояние"]) + tab1 +
                        Convert.ToString(sqlReader["Интернет"]) + tab1 +
                        Convert.ToString(sqlReader["Аудитория"]) + tab1 +
                        Convert.ToString(sqlReader["Номер задания"]) + tab1 +
                        Convert.ToString(sqlReader["Тип помещения"]) + tab1 +
                        Convert.ToString(sqlReader["Инвентарный номер"]) + tab1 +
                        Convert.ToString(sqlReader["Дополнительная информация"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }

            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private async void ПОСортировкаПоСрокамДействияЛицензии_Click(object sender, EventArgs e)
        {
            Вывод.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [ПО] WHERE [Действие лицензии]=@Действиелицензии", sqlConnection);

            try
            {
                command.Parameters.AddWithValue("Действиелицензии", ПОДействиелицензии.Text);
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    Вывод.Items.Add(Convert.ToString(sqlReader["ID ПО"]) + tab1 +
                        Convert.ToString(sqlReader["Название"]) + tab1 +
                        Convert.ToString(sqlReader["Тип лицензии"]) + tab1 +
                        Convert.ToString(sqlReader["Статус лицензии"]) + tab1 +
                        Convert.ToString(sqlReader["Действие лицензии"]) + tab1 +
                        Convert.ToString(sqlReader["Дата покупки"]) + tab1 +
                        Convert.ToString(sqlReader["Дата окончания лицензии"]) + tab1 +
                        Convert.ToString(sqlReader["Количество лицензий"]) + tab1 +
                        Convert.ToString(sqlReader["Версия"]) + tab1 +
                        Convert.ToString(sqlReader["Описание"]) + tab1 +
                        Convert.ToString(sqlReader["Стоимость"]) + tab1 +
                        Convert.ToString(sqlReader["Категория"]) + tab1 +
                        Convert.ToString(sqlReader["Подразделение"]) + tab1 +
                        Convert.ToString(sqlReader["Обновление"]) + tab1 +
                        Convert.ToString(sqlReader["Инвентарный номер"]) + tab1 +
                        Convert.ToString(sqlReader["Рекомендуемые требования"]) + tab1 +
                        Convert.ToString(sqlReader["Использовано лицензий"]) + tab1 +
                        Convert.ToString(sqlReader["Лицензионный номер"]) + tab1 +
                        Convert.ToString(sqlReader["Пароль"]) + tab1 +
                        Convert.ToString(sqlReader["Язык"]) + tab1 +
                        Convert.ToString(sqlReader["Осталось лицензий"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }

            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }
        private async void ПОСортировкаПоТипамЛицензии_Click(object sender, EventArgs e)
        {
            Вывод.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [ПО] WHERE [Тип лицензии]=@Типлицензии", sqlConnection);

            try
            {
                command.Parameters.AddWithValue("Типлицензии", ПОТиплицензии.Text);
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    Вывод.Items.Add(Convert.ToString(sqlReader["ID ПО"]) + tab1 +
                        Convert.ToString(sqlReader["Название"]) + tab1 +
                        Convert.ToString(sqlReader["Тип лицензии"]) + tab1 +
                        Convert.ToString(sqlReader["Статус лицензии"]) + tab1 +
                        Convert.ToString(sqlReader["Действие лицензии"]) + tab1 +
                        Convert.ToString(sqlReader["Дата покупки"]) + tab1 +
                        Convert.ToString(sqlReader["Дата окончания лицензии"]) + tab1 +
                        Convert.ToString(sqlReader["Количество лицензий"]) + tab1 +
                        Convert.ToString(sqlReader["Версия"]) + tab1 +
                        Convert.ToString(sqlReader["Описание"]) + tab1 +
                        Convert.ToString(sqlReader["Стоимость"]) + tab1 +
                        Convert.ToString(sqlReader["Категория"]) + tab1 +
                        Convert.ToString(sqlReader["Подразделение"]) + tab1 +
                        Convert.ToString(sqlReader["Обновление"]) + tab1 +
                        Convert.ToString(sqlReader["Инвентарный номер"]) + tab1 +
                        Convert.ToString(sqlReader["Рекомендуемые требования"]) + tab1 +
                        Convert.ToString(sqlReader["Использовано лицензий"]) + tab1 +
                        Convert.ToString(sqlReader["Лицензионный номер"]) + tab1 +
                        Convert.ToString(sqlReader["Пароль"]) + tab1 +
                        Convert.ToString(sqlReader["Язык"]) + tab1 +
                        Convert.ToString(sqlReader["Осталось лицензий"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }

            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }
        private async void ПОСортировкаПоНазначению_Click(object sender, EventArgs e)
        {
            Вывод.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [ПО] WHERE [Категория]=@Категория", sqlConnection);

            try
            {
                command.Parameters.AddWithValue("Категория", ПОКатегория.Text);
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    Вывод.Items.Add(Convert.ToString(sqlReader["ID ПО"]) + tab1 +
                        Convert.ToString(sqlReader["Название"]) + tab1 +
                        Convert.ToString(sqlReader["Тип лицензии"]) + tab1 +
                        Convert.ToString(sqlReader["Статус лицензии"]) + tab1 +
                        Convert.ToString(sqlReader["Действие лицензии"]) + tab1 +
                        Convert.ToString(sqlReader["Дата покупки"]) + tab1 +
                        Convert.ToString(sqlReader["Дата окончания лицензии"]) + tab1 +
                        Convert.ToString(sqlReader["Количество лицензий"]) + tab1 +
                        Convert.ToString(sqlReader["Версия"]) + tab1 +
                        Convert.ToString(sqlReader["Описание"]) + tab1 +
                        Convert.ToString(sqlReader["Стоимость"]) + tab1 +
                        Convert.ToString(sqlReader["Категория"]) + tab1 +
                        Convert.ToString(sqlReader["Подразделение"]) + tab1 +
                        Convert.ToString(sqlReader["Обновление"]) + tab1 +
                        Convert.ToString(sqlReader["Инвентарный номер"]) + tab1 +
                        Convert.ToString(sqlReader["Рекомендуемые требования"]) + tab1 +
                        Convert.ToString(sqlReader["Использовано лицензий"]) + tab1 +
                        Convert.ToString(sqlReader["Лицензионный номер"]) + tab1 +
                        Convert.ToString(sqlReader["Пароль"]) + tab1 +
                        Convert.ToString(sqlReader["Язык"]) + tab1 +
                        Convert.ToString(sqlReader["Осталось лицензий"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }

            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private async void ДобавитьУчётПО_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO [ПК-ПО] ([ID ПК], [ID ПО])VALUES(@IDПК, @IDПО)", sqlConnection);
                command.Parameters.AddWithValue("IDПК", ПКПОIDПК.Text);
                command.Parameters.AddWithValue("IDПО", ПКПОIDПО.Text);
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }
            ОбновитьПКПО("SELECT * FROM [ПК-ПО]");
        }
        private async void УдалитьУчётПО_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM [ПК-ПО] WHERE [ID ПК]=@IDПК AND [ID ПО]=@IDПО", sqlConnection);
                command.Parameters.AddWithValue("IDПК", ПКПОIDПК.Text);
                command.Parameters.AddWithValue("IDПО", ПКПОIDПО.Text);
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }
            ОбновитьПКПО("SELECT * FROM [ПК-ПО]");
        }
        private async void РедактироватьУчётПО_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("UPDATE [ПК-ПО] SET [ID ПК]=@IDПК, [ID ПО]=@IDПО WHERE [ID ПК]=@IDПК, [ID ПО]=@IDПО", sqlConnection);
                command.Parameters.AddWithValue("IDПК", ПКПОIDПК.Text);
                command.Parameters.AddWithValue("IDПО", ПКПОIDПО.Text);
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }
            ОбновитьПКПО("SELECT * FROM [ПК-ПО]");
        }

        private async void УчетПрограммногоОбеспеченияУстановленногоНаПК_Click(object sender, EventArgs e)
        {
            Вывод.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT [ПК-ПО].[ID ПК], [ПО].Название, ПО.[ID ПО] FROM [ПК-ПО] INNER JOIN [ПО] ON [ПК-ПО].[ID ПО] = [ПО].[ID ПО] INNER JOIN[ПК] ON[ПК-ПО].[ID ПК] = [ПК].[ID ПК];", sqlConnection);
            Вывод.Items.Add("ID ПК" + tab + "Название ПО" + tab + "ID ПО");
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    Вывод.Items.Add(Convert.ToString(sqlReader["ID ПК"]) + tab1 +
                        Convert.ToString(sqlReader["Название"]) + tab1 +
                        Convert.ToString(sqlReader["ID ПО"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                await sqlConnection.OpenAsync();
            }

            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        public void Вкладки_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Вкладки.SelectedIndex)
            {
                case 0:
                    ОбновитьПК("SELECT * FROM [ПК]");
                    break;
                case 1:
                    ОбновитьПО("SELECT * FROM [ПО]");
                    break;
                case 2:
                    ОбновитьЗаявки("SELECT * FROM [Заявки]");
                    break;
                case 3:
                    ОбновитьПКПО("SELECT * FROM [ПК-ПО]");
                    break;
            }
        }
    }
}
