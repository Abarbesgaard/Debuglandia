﻿using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
namespace Debuglandia
{
    /// <summary>
    /// This class is used for debugging purposes.
    /// </summary>
    public class Debugger
    {
        #region Properties
        /// <summary>
        /// Indicates the indentation level of the debug window, level 0.
        /// </summary>
        private static int indentationLevelZero = 0;
        /// <summary>
        /// Indicates the indentation level of the debug window, level 1.
        /// </summary>
        private static int indentationLevelOne = 1;
        /// <summary>
        /// Creates a new Stopwatch object.
        /// </summary>
        Stopwatch watch = new();
        #endregion


        /// <summary>
        /// This method indicates that the method has started and initiated. Begins the Stopwatch object and writes the name of the method to the debug window.
        /// </summary>
        /// <param name="methodName">Navnet på metoden som kalles. </param>
        public void MethodStart(string Name)
        {
            // Creates an indentation level of 0.
            Debug.IndentLevel = indentationLevelZero;
            // Writes the name of the method to the debug window.
            Debug.WriteLine($"[{Name}]");
            // Begins the Stopwatch object.
            watch.Start();
            // Creates an indentation level of 1.
            Debug.IndentLevel = indentationLevelOne;
            // Writes that the method has initialized.
            Debug.WriteLine($"{(char)26} initialized");
            // Creates an indentation level of 0.
            Debug.IndentLevel = indentationLevelZero;
        }


        /// <summary>
        /// This method indicates that the method has ended. Also stops the Stopwatch object and writes the lifespan of the method to the debug window.
        /// </summary>
        /// <param name="methodName">The name of the method which is being called.</param>
        public void MethodStop(string methodName)
        {
            // Creates an indentation level of 0.
            Debug.IndentLevel = indentationLevelZero;
            // Terminates the Stopwatch object.
            watch.Stop();
            // Creates an indentation level of 1.
            Debug.IndentLevel = indentationLevelOne;
            // Writes the lifespan of the method to the debug window.
            Debug.WriteLine($"{(char)27} Method Lifespan: {watch.ElapsedMilliseconds} ms");
            // Creates an indentation level of 0.
            Debug.IndentLevel = indentationLevelZero;
            // Writes that the method has ended.
            Debug.WriteLine($"[/{methodName}]\n");
            // Creates an indentation level of 0.
            Debug.IndentLevel = indentationLevelZero;
        }

        /// <summary>
        /// This method is used to write a message to the debug window.
        /// </summary>
        /// <param name="message"> Beskeden som skal skrives til debug vinduet.</param>
        /// <returns>Returnere beskeden som er skrevet til debug vinduet.</returns>
        public string Message(string message)
        {
            // Creates an indentation level of 1.
            Debug.IndentLevel = indentationLevelOne;
            // Writes the message to the debug window.
            Debug.WriteLine($"{(char)33}{message}");
            // Creates an indentation level of 0.
            Debug.IndentLevel = indentationLevelZero;
            // Returns the message which is being written to the debug window.
            return message;
        }

        /// <summary>
        /// This method is used to write an important message to the debug window.
        /// </summary>
        /// <param name="message">The message which is being written to the debug window.</param>
        /// <returns>Returns the message which is being written to the debug window.</returns>
        public string MessageImportant(string message)
        {
            // Creates an indentation level of 1.
            Debug.IndentLevel = indentationLevelOne;
            // Writes the message to the debug window.
            Debug.WriteLine($"{(char)19}{message}");
            // Creates an indentation level of 0.
            Debug.IndentLevel = indentationLevelZero;
            // Returns the message which is being written to the debug window.
            return message;
        }

        /// <summary>
        /// This Method is used to debug SQL Commands, it will write the command to the debug window. This will initate the SQL Connection.
        /// </summary>
        /// <param name="operation">The SQL Command which is being executed.</param>
        /// <returns>Returns a new Debugger object.</returns>
        public Debugger SQLCommandInitialized(string operation)
        {
            // Creates an indentation level of 1.
            Debug.IndentLevel = indentationLevelOne;
            // Writes the SQL Command to the debug window.
            string debugLine = $"{(char)1} SQL Command: {operation}";
            // Writes the SQL Command to the debug window.
            Debug.WriteLine(debugLine);
            // Creates an indentation level of 0.
            Debug.IndentLevel = indentationLevelZero;
            // Returns a new Debugger object.
            return new Debugger();
        }
        /// <summary>
        /// This Method shows that the SQL Reader has been initialized.
        /// </summary>
        /// <returns>Returns a new Debugger object.</returns>
        public Debugger ReaderInitialised()
        {
            // Creates an indentation level of 1.
            Debug.IndentLevel = 1;
            // Writes that the SQL Reader has been initialized.
            Debug.WriteLine($"{(char)5} Reader initialized");
            // Creates an indentation level of 0.
            Debug.IndentLevel = 0;
            return this;
        }

        /// <summary>
        /// This method is used to debug SQL Commands, it will write the command to the debug window that the Reader has terminated. 
        /// </summary>
        public void ReaderTerminating()
        {
            // Creates an indentation level of 1.
            Debug.IndentLevel = indentationLevelOne;
            // Writes that the SQL Reader has terminated.
            Debug.WriteLine($"{(char)5} Reader terminated");
            // Creates an indentation level of 0.
            Debug.IndentLevel = indentationLevelZero;

        }
        /// <summary>
        /// This method is used to debug SQL Commands, it will write the command to the debug window that the SQL Connection has terminated.
        /// </summary>
        public void SQLConnectionTerminating()
        {
            // Creates an indentation level of 1.
            Debug.IndentLevel = indentationLevelOne;
            // Writes that the SQL Connection has terminated.
            Debug.WriteLine($"{(char)3} SQL Connection Terminated");
            // Creates an indentation level of 0.
            Debug.IndentLevel = indentationLevelZero;

        }
        /// <summary>
        /// This method is used to debug SQL Commands, it will write the command to the debug window that the SQL Command has terminated.
        /// </summary>
        public void SQLCommandTerminating()
        {
            // Creates an indentation level of 1.
            Debug.IndentLevel = indentationLevelOne;
            // Writes that the SQL Command has terminated.
            Debug.WriteLine($"{(char)5} Command initialized");
            // Creates an indentation level of 0.
            Debug.IndentLevel = indentationLevelZero;
        }
        /// <summary>
        /// This Method is used to let you know that multiple Variables has been declared.
        /// </summary>
        public void Variable()
        {
            // Creates an indentation level of 1.
            Debug.IndentLevel = indentationLevelOne;
            // Writes that Multiple Variables has been declared.
            Debug.WriteLine($"{(char)15} Variable(s) Declared");
            // Creates an indentation level of 0.
            Debug.IndentLevel = indentationLevelZero;
        }
        /// <summary>
        /// This Method is used to let you know that a Variable has been declared.
        /// </summary>
        /// <param name="variableName">Name of the variable you declared</param>
        public void Variable(string variableName)
        {
            // Creates an indentation level of 1.
            Debug.IndentLevel = indentationLevelOne;
            // Writes that the Variable has been declared.
            Debug.WriteLine($"{(char)6}The Variable {variableName} Declared");
            // Creates an indentation level of 0.
            Debug.IndentLevel = indentationLevelZero;
        }
    }
}
