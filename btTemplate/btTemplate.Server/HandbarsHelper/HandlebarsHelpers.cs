using HandlebarsDotNet;
using System;

public static class HandlebarsHelpers
{
    public static void RegisterIfEqualsHelper()
    {
        Handlebars.RegisterHelper("ifEquals", (output, options, context, arguments) =>
        {
            var arg1 = arguments[0];
            var arg2 = arguments[1];

            if (arg1.Equals(arg2))
            {
                options.Template(output, context);
            }
            else
            {
                options.Inverse(output, context);
            }
        });
    }

    public static void RegisterGetDateHelper()
    {
        Handlebars.RegisterHelper("getCurrentDate", (writer, context, parameters) =>
        {
            var currentDate = DateTime.Now.ToString("dd-MM-yyyy");
            writer.Write(currentDate);
        });
    }
    public static void RegisterifContains()
    {
        Handlebars.RegisterHelper("ifContains", (output, options, context, arguments) =>
        {
           
            List<Int32> arg1 = (List<Int32>)arguments[0];
            Int32 arg2 = (int)arguments[1];
            if (arg1.Contains(arg2))
            {
                options.Template(output, context);
            }
            else
            {
                options.Inverse(output, context);
            }
        });
    }
}