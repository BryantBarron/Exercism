using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();

        // catch for yelling
        if (Regex.IsMatch(statement, "[A-Z]") &&
           !Regex.IsMatch(statement, "[a-z]") &&
           (statement[statement.Length - 1] != '?')
           )
        {
            return "Whoa, chill out!";
        }

        // catch for empty statement
        if (statement == ""){
            return "Fine. Be that way!";
        }

        // catch for non yelling question
        if(statement != statement.ToUpper() &&
                  (statement.Length > 0) &&
                 (statement[statement.Length - 1] == '?')
                )
        {
            return "Sure.";
        }

        // catch for yelling a question
        if(Regex.IsMatch(statement, "[A-Z]") &&
                 (statement[statement.Length - 1] == '?')){
            return "Calm down, I know what I'm doing!";

        }

        // catch for non lettered question
        if( (statement.Length > 0) &&
            (statement[statement.Length - 1] == '?'))
        {
           return "Sure.";
        }

        return "Whatever.";
    }
}