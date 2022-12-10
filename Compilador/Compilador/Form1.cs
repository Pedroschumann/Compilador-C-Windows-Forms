using Compilador.c_;
using System.Text;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Compilador
{
    public partial class Compilador : Form
    {
        private OpenFileDialog abrirDig;
        private SaveFileDialog saveDig;

        public Compilador()
        {
            InitializeComponent();
        }

        private void Compilador_Load(object sender, EventArgs e)
        {
            
        }

        private void updateLineNumbers()
        {
            var charPoint = new Point(0, 1);
            int firstIndex = textBox1.GetCharIndexFromPosition(charPoint);
            int firstLine = textBox1.GetLineFromCharIndex(firstIndex);

            charPoint.X = ClientRectangle.Width;
            charPoint.Y = ClientRectangle.Height;
            int lastIndex = textBox1.GetCharIndexFromPosition(charPoint);
            int lastLine = textBox1.GetLineFromCharIndex(lastIndex) + 1;

            if (textBox1.Text.EndsWith("\n"))
                lastLine++;

            var numbers = new StringBuilder();
            for (int idxLine = firstLine; idxLine < lastLine; idxLine++)
                numbers.Append((idxLine + 1).ToString() + "\n");

            textBox4.Text = numbers.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updateLineNumbers();
        }

        private void textBox1_VScroll(object sender, EventArgs e)
        {
            int startY = textBox1.GetPositionFromCharIndex(0).Y % (textBox1.Font.Height + 1);
            textBox4.Location = new Point(0, startY);

            updateLineNumbers();
        }

        private void editor_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            splitContainer1.SplitterDistance = (25 * (int)textBox1.ZoomFactor);
            textBox4.Width = (25 * (int)textBox1.ZoomFactor);
            textBox4.ZoomFactor = textBox1.ZoomFactor;

            updateLineNumbers();
        }

        private void salvarctrlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
               saveDig = new SaveFileDialog();

                saveDig.Filter = "Arquivo de Texto (*.txt) | *.txt";

                if (this.textBox3.Text.Length == 0)
                {
                    if (saveDig.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveDig.FileName, this.textBox1.Text);
                        this.textBox3.Text = saveDig.FileName;
                    }
                }
                else
                {
                    File.WriteAllText(this.textBox3.Text, this.textBox1.Text);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                saveDig = null;
            }
        }

        private void abrirctrloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                abrirDig = new OpenFileDialog();

                if(abrirDig.ShowDialog() == DialogResult.OK)
                {
                    this.textBox1.Text = File.ReadAllText(abrirDig.FileName);
                    this.textBox3.Text = abrirDig.FileName;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                abrirDig = null;
            }
        }

        private void novoctrlnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBox1.Text) || !string.IsNullOrEmpty(this.textBox2.Text) || !string.IsNullOrEmpty(this.textBox3.Text))
            {
                this.textBox1.Text = string.Empty;
                this.textBox2.Text = string.Empty;
                this.textBox3.Text = string.Empty;
            }
        }

        private void compilarF7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = string.Empty;
            Lexico lexico = new Lexico();
            Sintatico sintatico = new Sintatico();
            Semantico semantico = new Semantico();
            lexico.setInput(textBox1.Text);            
            try
            {
                sintatico.parse(lexico, semantico);
                var palavra = "";
                foreach (string palavras in semantico.codigo)
                {
                    palavra += palavras + Environment.NewLine;

                }
                StreamWriter sw = new StreamWriter(this.textBox3.Text.Substring(0, this.textBox3.Text.IndexOf(".txt")) + ".il");
                sw.WriteLine(palavra);
                sw.Close();

                textBox2.Text += "programa compilado com sucesso" + Environment.NewLine;
            }
            catch (LexicalError er)
            {  // tratamento de erros
                textBox2.Text = String.Empty;
                if (er.Message == "símbolo inválido")
                    textBox2.Text += "Erro na linha " + textBox1.Text.Substring(0, er.getPosition()).Split("\n").Length + " - " + textBox1.Text.Substring(er.getPosition(), 1) + " " + er.Message;
                else textBox2.Text += "Erro na linha " + textBox1.Text.Substring(0, er.getPosition()).Split("\n").Length + " - " + er.Message; 
            }
            catch (SyntaticError er)
            {
                if (sintatico.getToken().Equals("$") || sintatico.getToken().Equals("fim de programa") || sintatico.getToken().Equals("fim de arquivo"))
                {
                    textBox2.Text = "Erro na linha " + er.getPosition() + " - " + " encontrado EOF " + er.Message;
                }
                else
                {
                    textBox2.Text = "Erro na linha " + er.getPosition() + " - " + " encontrado " + sintatico.getToken() + er.Message;
                }
                

                //Trata erros sintáticos
                //linha 				sugestão: converter getPosition em linha
                //símbolo encontrado    sugestão: implementar um método getToken no sintatico
                //mensagem - símbolos esperados,   alterar ParserConstants.java, String[] PARSER_ERROR	
            }
            catch(SemanticError er)
            {
                textBox2.Text = er.Message;
            }
        }   

        private void equipeF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox2.Text += "Equipe composta por: Bernardo Kretzer e Pedro Schumann." + Environment.NewLine;
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //copiado = this.textBox1.Text;
            if (textBox1.SelectedText != "")
            {
                Clipboard.SetText(textBox1.SelectedText);
            }
        }

        private void colarctrlvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text = copiado;
            if (Clipboard.ContainsText())
            {
                textBox1.SelectedText = Clipboard.GetText();
            }
        }

        private void recortarctrlxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                Clipboard.SetText(textBox1.SelectedText);
                textBox1.SelectedText = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}