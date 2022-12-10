using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System;
using System.Configuration;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Linq.Expressions;

namespace Compilador.c_
{
    public class Semantico : Constants
    {
        public List<string> codigo = new List<String>();
        Stack pilha_tipos = new Stack();
        public string operador;
        public string tipoVar;
        public List<string> listaId = new List<String>();
        public Dictionary<string, string> TS = new Dictionary<string, string>();
        public Stack pilhaRotulos = new Stack();
        int numRotulo = 0;
        public void executeAction(int action, Token token)
        {
            Console.WriteLine("Ação #" + action + ", Token: " + token);
            switch (action)
            {
                case 1: acao_01(); break;
                case 2: acao_02(); break;
                case 3: acao_03(); break;
                case 4: acao_04(); break;
                case 5: acao_05(token); break;
                case 6: acao_06(token); break;
                case 7: acao_07(); break;
                case 8: acao_08(); break;
                case 9: acao_09(token); break;
                case 10: acao_10(); break;
                case 11: acao_11(); break;
                case 12: acao_12(); break;
                case 13: acao_13(); break;
                case 14: acao_14(); break;
                case 15: acao_15(); break;
                case 16: acao_16(); break;
                case 17: acao_17(); break;
                case 18: acao_18(); break;
                case 19: acao_19(); break;
                case 20: acao_20(); break;
                case 21: acao_21(token); break;
                case 22: acao_22(token); break;
                case 24: acao_24(); break;
                case 25: acao_25(); break;
                case 26: acao_26(); break;
                case 27: acao_27(); break;
                case 28: acao_28(); break;
                case 30: acao_30(token); break;
                case 31: acao_31(); break;
                case 32: acao_32(token); break;
                case 33: acao_33(token); break;
                case 34: acao_34(); break;
                case 35: acao_35(); break;
            }

        }
        public void acao_01()
        {
            string tipo1 = "";
            string tipo2 = "";
            tipo1 += pilha_tipos.Pop();
            tipo2 += pilha_tipos.Pop();
            if (tipo1 != "float64" && tipo1 != "int64" || tipo2 != "float64" && tipo2 != "int64")
            {
                throw new SemanticError("tipo(s) incompatível(is) em expressão aritmética");
            }
            if (tipo1 == "float64" || tipo2 == "float64")
            {
                pilha_tipos.Push("float64");
            }
            else
            {
                pilha_tipos.Push("int64");
            }
            codigo.Add("add");
        }
        public void acao_02()
        {
            string tipo1 = "";
            string tipo2 = "";
            tipo1 += pilha_tipos.Pop();
            tipo2 += pilha_tipos.Pop();
            if (tipo1 != "float64" && tipo1 != "int64" || tipo2 != "float64" && tipo2 != "int64")
            {
                throw new SemanticError("tipo(s) incompatível(is) em expressão aritmética");
            }
            if (tipo1 == "float64" || tipo2 == "float64")
            {
                pilha_tipos.Push("float64");
            }
            else
            {
                pilha_tipos.Push("int64");
            }

            codigo.Add("sub");
        }

        public void acao_03()
        {
            string tipo1 = "";
            string tipo2 = "";
            tipo1 += pilha_tipos.Pop();
            tipo2 += pilha_tipos.Pop();
            if (tipo1 != "float64" && tipo1 != "int64" || tipo2 != "float64" && tipo2 != "int64")
            {
                throw new SemanticError("tipo(s) incompatível(is) em expressão aritmética");
            }
            if (tipo1 == "float64" || tipo2 == "float64")
            {
                pilha_tipos.Push("float64");
            }
            else
            {
                pilha_tipos.Push("int64");
            }

            codigo.Add("mul");
        }

        public void acao_04()
        {
            string tipo1 = "";
            string tipo2 = "";
            tipo1 += pilha_tipos.Pop();
            tipo2 += pilha_tipos.Pop();
            if (tipo1 != "float64" && tipo1 != "int64" || tipo2 != "float64" && tipo2 != "int64")
            {
                throw new SemanticError("tipo(s) incompatível(is) em expressão aritmética");
            }
            if (tipo1 == "float64" || tipo2 == "float64")
            {
                pilha_tipos.Push("float64");
            }
            else
            {
                pilha_tipos.Push("int64");
            }

            codigo.Add("div");
        }

        public void acao_05(Token token)
        {
            string lexema = token.getLexeme();
            string valorStr = "";
            if (isNotacaoCient(token.getLexeme()))
            {
                int posicaoD = lexema.IndexOf('d');
                string potenciaStr = lexema.Substring(posicaoD + 1);
                int potencia = int.Parse(potenciaStr);
                var mutilplicando = (int)Math.Pow(10, potencia);

                valorStr = lexema.Substring(0, posicaoD);

                var valor = int.Parse(valorStr) * mutilplicando;

                pilha_tipos.Push("int64");
                codigo.Add("ldc.i8 " + valor);
                codigo.Add("conv.r8");
            }
            else
            {
                pilha_tipos.Push("int64");
                codigo.Add("ldc.i8 " + lexema);
                codigo.Add("conv.r8");
            }

        }

        public void acao_06(Token token) {
            string lexema = token.getLexeme();
            string valorStr = "";

            if (lexema.Substring(0, 1) == ".")
            {
                lexema = "0" + lexema;
            }
            if (isNotacaoCient(token.getLexeme()))
            {
                int posicaoD = lexema.IndexOf('d');
                string potenciaStr = lexema.Substring(posicaoD + 1);
                int potencia = int.Parse(potenciaStr);
                int mutilplicando = (int)Math.Pow(10, potencia);

                valorStr = lexema.Substring(0, posicaoD);
                double valorFloat = double.Parse(valorStr);
                double valor = valorFloat * mutilplicando;

                pilha_tipos.Push("float64");
                codigo.Add("ldc.r8 " + valor);
            }
            else
            {
                pilha_tipos.Push("float64");
                codigo.Add("ldc.r8 " + lexema);
            }

        }

        public void acao_07()
        {
            string tipo1 = "";
            tipo1 += pilha_tipos.Pop();
            if (tipo1 != "float64" && tipo1 != "int64")
            {
                throw new SemanticError("tipo(s) incompatível(is) em expressão aritmética");
            }else pilha_tipos.Push(tipo1);
        }
        public void acao_08()
        {
            string tipo1 = "";
            tipo1 += pilha_tipos.Pop();
            if (tipo1 != "float64" && tipo1 != "int64")
            {
                throw new SemanticError("tipo(s) incompatível(is) em expressão aritmética");
            }
            else pilha_tipos.Push(tipo1);
            codigo.Add("ldc.i8 -1");
            codigo.Add("conv.r8");
            codigo.Add("mul");

        }

        public void acao_09(Token token)
        {
            this.operador = token.getLexeme();
        }

        public void acao_10()
        {
            string tipo1 = "";
            string tipo2 = "";

            tipo1 += pilha_tipos.Pop();
            tipo2 += pilha_tipos.Pop();
            if((tipo1 == tipo2) || ((tipo1 == "float64" || tipo1 == "int64") && (tipo2 == "float64" || tipo2 == "int64")))
            {
                pilha_tipos.Push("bool");
                
                if (tipo1 == "string")
                {
                    
                    codigo.Add("call int32 [mscorlib]System.String::Compare(string, string)");
                    codigo.Add("ldc.i8 0");
                }
            }
            else
            {
                throw new SemanticError("tipos incompatíveis em expressão relacional");
            }

            switch (this.operador)
            {
                case ">": codigo.Add("cgt");
                break;
                case "<": codigo.Add("clt");
                break;
                case "==": codigo.Add("ceq");
                break;
                case "!=":
                    codigo.Add("ceq");
                    codigo.Add("ldc.i8 0");
                    codigo.Add("ceq");
                break;
            }
        }

        public void acao_11()
        {
            pilha_tipos.Push("bool");
            codigo.Add("ldc.i4.1");
        }

        public void acao_12()
        {
            pilha_tipos.Push("bool");
            codigo.Add("ldc.i4.0");
        }

        public void acao_13()
        {
            string tipo = "";
            tipo += pilha_tipos.Pop();
            if (tipo == "bool") pilha_tipos.Push("bool");
            else throw new SemanticError("tipo incompatível em expressão lógica");
            codigo.Add("ldc.i4.1");
            codigo.Add("xor");
        }

        public void acao_14()
        {
            string tipo = "";
            tipo += pilha_tipos.Pop();
            if (tipo == "char") {
                tipo = "string";
            }
            if (tipo == "int64") {
                codigo.Add("conv.i8");
            }
            codigo.Add("call void [mscorlib]System.Console::Write("+tipo+")");
        }

        public void acao_15()
        {
            codigo.Add(
            ".assembly extern mscorlib { }"+ Environment.NewLine +
            ".assembly _codigo_objeto{ }" + Environment.NewLine +
            ".module _codigo_objeto.exe" + Environment.NewLine +

            ".class public _UNICA{ " + Environment.NewLine +
            ".method static public void _principal()" + Environment.NewLine +
            "{" + Environment.NewLine +
            ".entrypoint");
        }

        public void acao_16()
        {
            codigo.Add(
               "ret" + Environment.NewLine +
                "}" + Environment.NewLine + 
            "}");
        }

        public void acao_17()
        {
            codigo.Add("ldstr \\n");
            codigo.Add("call void [mscorlib]System.Console::Write(string)");
        }

        public void acao_18()
        {
            string tipo1 = "";
            string tipo2 = "";
            tipo1 += pilha_tipos.Pop();
            tipo2 += pilha_tipos.Pop();
            if (tipo1 == "boll" && tipo2 == "bool")
            {
                pilha_tipos.Push("bool");
                codigo.Add("and");
            }
            else
            {
                throw new SemanticError("tipo(s) incompatível(is) em expressão lógica");
            }
        }

        public void acao_19()
        {
            string tipo1 = "";
            string tipo2 = "";
            tipo1 += pilha_tipos.Pop();
            tipo2 += pilha_tipos.Pop();
            if (tipo1 == "boll" || tipo2 == "bool")
            {
                pilha_tipos.Push("bool");
                codigo.Add("or");
            }
            else
            {
                throw new SemanticError("tipo(s) incompatível(is) em expressão lógica");
            }
        }

        public void acao_20()
        {
            string tipo1 = "";
            string tipo2 = "";
            tipo1 += pilha_tipos.Pop();
            tipo2 += pilha_tipos.Pop();
            if (tipo1 == "int64" && tipo2 == "int64")
            {
                pilha_tipos.Push("int64");
                codigo.Add("div");      
            }
            else
            {
                throw new SemanticError("tipo(s) incompatível(is) em expressão aritmética");
            }
        }
        public void acao_21(Token token)
        {
            string lexema = token.getLexeme();
            switch (lexema)
            {
                case "\\s": lexema = "\" \"";
                    break;
                case "\\n": lexema = "\"\\n\"";
                    break;
                case "\\t": lexema = "\"\\t\"";
                    break;
            }

            pilha_tipos.Push("char");
            codigo.Add("ldstr " + lexema);

        }

        public void acao_22(Token token)
        {
            pilha_tipos.Push("string");
            codigo.Add("ldstr " + token.getLexeme());
        }

        public void acao_24()
        {
            this.numRotulo++;
            this.codigo.Add("brfalse rotulo_bp_" + numRotulo);
            this.pilhaRotulos.Push("rotulo_bp_" + numRotulo);
        }

        public void acao_25()
        {
            this.numRotulo++;
            this.codigo.Add("br rotulo_bp_" + numRotulo);
            this.codigo.Add(this.pilhaRotulos.Pop() + ":");
            this.pilhaRotulos.Push("rotulo_bp_" + numRotulo);
        }

        public void acao_26()
        {
            this.codigo.Add(this.pilhaRotulos.Pop() + ":");
        }

        public void acao_27()
        {
            this.numRotulo++;
            this.codigo.Add("rotulo_bp_" + numRotulo + ":");
            this.pilhaRotulos.Push("rotulo_bp_" + numRotulo);
        }

        public void acao_28()
        {
            this.codigo.Add("brtrue " + pilhaRotulos.Pop());
            this.pilhaRotulos.Push("rotulo_bp_" + numRotulo);
        }

        public void acao_30(Token token)
        {
            switch (token.getLexeme())
            {
                case "string": tipoVar = "string"; break;
                case "char": tipoVar = "char"; break;
                case "int": tipoVar = "int64"; break;
                case "float": tipoVar = "float64"; break;
                case "boolean": tipoVar = "bool"; break;
            }
        }

        public void acao_31()
        {
            foreach(string id in listaId)
            {
                TS.Add(id, tipoVar);
                codigo.Add(".locals(" + tipoVar + " " + id + ")");
            }
            listaId.Clear();
        }

        public void acao_32(Token token)
        {
            listaId.Add(token.getLexeme());
        }

        public void acao_33(Token token)
        {
            var id = token.getLexeme();
            var tipoId = TS[id];
            pilha_tipos.Push(tipoId);
            codigo.Add("ldloc " + id);
            if(tipoId == "int64")
            {
                codigo.Add("conv.r8");
            }
        }

        public void acao_34()
        {
            string id = listaId.First();
            listaId.Remove(id);
            string tipoId = TS[id];
            string tipoExp = pilha_tipos.Pop().ToString();
            if (tipoId == "int64")
            {
                codigo.Add("conv.i8");
            }
            codigo.Add("stloc " + id);
        }

        public void acao_35()
        {
            string classe = "";
            foreach(string id in listaId)
            {
                
                string tipoId = TS[id];
                if (tipoId != "string")
                {
                    if (tipoId == "int64") classe = ".Int64";
                    else if (tipoId == "float64") classe = ".Double";
                    else if (tipoId == "bool") classe = ".Boolean";
                    codigo.Add("call string [mscorlib]System.Console::ReadLine()");
                    codigo.Add("call " + tipoId + " [mscorlib]System" + classe + "::Parse(string)");
                    
                    
                }
                else
                {
                    codigo.Add("call string [mscorlib]System.Console::ReadLine()");
                }
               
                codigo.Add("stloc " + id);
            }
            listaId.Clear();
        }

        public bool isNotacaoCient(String lexema)
        {
            if (lexema.IndexOf('d') == -1)
            {
                return false;
            }
            return true;
        }

    }    
}


