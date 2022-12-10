public class LexicalError : AnalysisError
{
    public LexicalError(String msg, int position): base(msg, position)
	 {
    }

    public LexicalError(String msg) : base(msg)
    {
    }
}
