namespace GCScript_Excel_Formula_Generator
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
            Start();
        }

        private void txt_SheetName_TextChanged(object sender, EventArgs e) => Start();

        private void txt_ColumnName_TextChanged(object sender, EventArgs e) => Start();

        private void btn_CopyMode01_Click(object sender, EventArgs e) => Clipboard.SetText(txt_Mode01.Text);

        private void btn_CopyMode02_Click(object sender, EventArgs e) => Clipboard.SetText(txt_Mode02.Text);

        private void btn_CopyMode03_Click(object sender, EventArgs e) => Clipboard.SetText(txt_Mode03.Text);

        private void Start()
        {
            if (string.IsNullOrWhiteSpace(txt_ColumnName.Text)) {
                lbl_Mode01.Text = "Letra da coluna";
                lbl_Mode02.Text = "Letra da coluna + Número da linha atual";
                lbl_Mode03.Text = "Intervalo da coluna";
                lbl_ExampleMode01.Text = "";
                lbl_ExampleMode02.Text = "";
                lbl_ExampleMode03.Text = "";
                txt_Mode01.Text = "";
                txt_Mode02.Text = "";
                txt_Mode03.Text = "";
                return; }

            string sheetName = string.IsNullOrWhiteSpace(txt_SheetName.Text) ? "" : $"'{txt_SheetName.Text}'!";
            string columnName = $"{txt_ColumnName.Text}";

            lbl_Mode01.Text = $"Letra da coluna \"{txt_ColumnName.Text}\"";
            txt_Mode01.Text = !string.IsNullOrWhiteSpace(sheetName) ?
                              $"""=SUBSTITUIR(ENDEREÇO(1;CORRESP("{columnName}";{sheetName}$1:$1;0);4);1;"")""" :
                              $"""=SUBSTITUIR(ENDEREÇO(1;CORRESP("{columnName}";$1:$1;0);4);1;"")""";
            lbl_ExampleMode01.Text = $"A";

            lbl_Mode02.Text = $"Letra da coluna \"{txt_ColumnName.Text}\" + Número da linha atual";
            txt_Mode02.Text = !string.IsNullOrWhiteSpace(sheetName) ?
                              $"""=INDIRETO(CONCAT("{sheetName}";SUBSTITUIR(ENDEREÇO(1;CORRESP("{columnName}";{sheetName}$1:$1;0);4);1;"");LIN()))""" :
                              $"""=INDIRETO(CONCAT(SUBSTITUIR(ENDEREÇO(1;CORRESP("{columnName}";$1:$1;0);4);1;"");LIN()))""";
            lbl_ExampleMode02.Text = $"""{sheetName}A2""";

            lbl_Mode03.Text = $"Intervalo da coluna \"{txt_ColumnName.Text}\"";
            txt_Mode03.Text = !string.IsNullOrWhiteSpace(sheetName) ?
                              $"""=INDIRETO(LET(l;SUBSTITUIR(ENDEREÇO(1;CORRESP("{columnName}";{sheetName}$1:$1;0);4);1;"");CONCAT("{sheetName}";l;":";l)))""" :
                              $"""=INDIRETO(LET(l;SUBSTITUIR(ENDEREÇO(1;CORRESP("{columnName}";$1:$1;0);4);1;"");CONCAT(l;":";l)))""";
            lbl_ExampleMode03.Text = $"""{sheetName}A:A""";
        }
    }
}
