using System.Text.RegularExpressions;

public class Lexico : ScannerConstants
{
    private int position;
    private String input;

    public Lexico()
    {
        input = "";
    }

    public Lexico(String input)
    {
        setInput(input);
    }

    public void setInput(String input)
    {
        this.input = input;
        setPosition(0);
    }

    public void setPosition(int pos)
    {
        position = pos;
    }

    public Token nextToken()
    {
        if ( ! hasInput() )
            return null;

        int start = position;

        int state = 0;
        int lastState = 0;
        int endState = -1;
        int end = -1;

        while (hasInput()){
            lastState = state;
            state = nextState(nextChar(), state);

            if (state< 0)
                break;
            else
            {
                if (tokenForState(state) >= 0)
                {
                    endState = state;
                    end = position;
                }
            }
        }

        if (endState < 0 || (endState != state && tokenForState(lastState) == -2))
             throw new LexicalError(SCANNER_ERROR[lastState], start);

        position = end;

        int token = tokenForState(endState);

        if (token == 0)
            return nextToken();
        else
        {
            string lexeme = input.Substring(start, end - start);
            token = lookupToken(token, lexeme);
            var linha = input.Substring(0, start).Split("\n");
           // var linha = Regex.Matches(input, "\n").Count;
            return new Token(token, lexeme, linha.Length);
        }
     }

    private int nextState(char c, int state)
    {
        int start = SCANNER_TABLE_INDEXES[state];
        int end = SCANNER_TABLE_INDEXES[state + 1] - 1;

        while (start <= end)
        {
            int half = (start + end) / 2;

            if (SCANNER_TABLE[half, 0] == c)
                return SCANNER_TABLE[half, 1];
            else if (SCANNER_TABLE[half, 0] < c)
                start = half + 1;
            else  //(SCANNER_TABLE[half, 0] > c)
                end = half - 1;
        }

        return -1;
    }

    private int tokenForState(int state)
    {
        if (state < 0 || state >= TOKEN_STATE.Length)
            return -1;

        return TOKEN_STATE[state];
    }

    public int lookupToken(int bas, String key)
    {
        int start = SPECIAL_CASES_INDEXES[bas];
        int end = SPECIAL_CASES_INDEXES[bas + 1] - 1;

        while (start <= end)
        {
            int half = (start + end) / 2;
            int comp = SPECIAL_CASES_KEYS[half].CompareTo(key);

            if (comp == 0)
                return SPECIAL_CASES_VALUES[half];
            else if (comp < 0)
                start = half + 1;
            else  //(comp > 0)
                end = half - 1;
        }

        return bas;
    }

    private bool hasInput()
    {
        return position < input.Length;
    }

    private char nextChar()
    {
        if (hasInput())
            return input[position++];
        else
            return Convert.ToChar(-1);
    }
}
