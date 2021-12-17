using System;

namespace diverseProjects
{

    class Program
    {
        static void Main() {

            bool loopActive = true;

            

            while (loopActive) {
                Console.Clear();
                Console.Write(
                "Qual projeto você gostaria de testar?                       .----.\n" +
                "1. Decodificador de Morse                      .---------.  | == |\n" +
                "2. Construtor de escadas                       |.-'''''-.|  |----|\n" +
                "3. Cadastro de funcionários                    ||       ||  | == |\n" +
                "4. Cadastro de produtos                        ||       ||  |----|\n" +
                "                                               |'-.....-'|  |::::|\n" +
                "                                               `'')---(''`  |____|\n" +
                "                                              /:::::::::::\\ ____'\n" +
                "0. Encerrar software                         /:::=======:::\\     \n" +
                "                                         --- `'''''''''''''`   '-'\n");
                Console.Write("\nDigite seu código: "); int input = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (input == 0) {
                    break;
                }

                switch (input) {
                    case 1: // Morse Decoder Project --------------------------------
                        MorseCode morseAlphabet = new();
                        Console.WriteLine("Comandos:\n0. para traduzir de ABC para morse;\n1. para traduzir de morse para ABC.");
                        Console.Write("Digite seu código: "); bool tipoTraducao = int.Parse(Console.ReadLine() ?? "") == 0 ? false : true;
                        Console.Write("Digite o texto a ser codificado/decodificado: "); string[] textoTraduzir = Console.ReadLine().Split();
                        string textoTraducao = "";

                        if (tipoTraducao) {
                            foreach (string code in textoTraduzir) {
                                if (morseAlphabet.GetMorseAlphabetValue().Contains(code)) {
                                    int index = morseAlphabet.GetMorseAlphabetValue().ToList().IndexOf(code);
                                    textoTraducao += morseAlphabet.GetMorseAlphabetKey()[index];
                                }
                                else if (code == "/") {
                                    textoTraducao += " ";
                                }
                            }
                        }
                        else {
                            foreach (char abc in string.Join(" ", textoTraduzir)) {
                                if (morseAlphabet.GetMorseAlphabetKey().Contains(char.Parse(abc.ToString().ToLower()))) {
                                    int index = morseAlphabet.GetMorseAlphabetKey().ToList().IndexOf(char.Parse(abc.ToString().ToLower()));
                                    textoTraducao += morseAlphabet.GetMorseAlphabetValue()[index] + " ";
                                }
                                else if (abc == ' ') {
                                    textoTraducao += "/ ";
                                }
                            }
                        }

                        Console.WriteLine(textoTraducao);
                        break;
                    case 2: // Stair Builder Project --------------------------------
                        Console.Write("Digite a largura da escada: "); int columns = int.Parse(Console.ReadLine());
                        Console.Write("Digite a altura da escada: "); int lines = int.Parse(Console.ReadLine());
                        Stair stair = new Stair(lines, columns);
                        StairBuilder.BuildStair(stair);
                        StairBuilder.ShowStair(stair);
                        break;
                    case 3: // Employee Register Project ----------------------------
                        Console.Write("How many employees will be registered? "); int registerQuantity = int.Parse(Console.ReadLine() ?? "");
                        Employee[] employees = new Employee[registerQuantity];
                        bool foundId = false;

                        for (int i = 0; i < registerQuantity; i++) {
                            Console.WriteLine($"Employee #{i + 1}:");
                            Console.Write("ID: "); int id = int.Parse(Console.ReadLine() ?? "");
                            Console.Write("Name: "); string name = Console.ReadLine() ?? "";
                            Console.Write("Salary: "); double salary = double.Parse(Console.ReadLine() ?? "");
                            Console.WriteLine();
                            employees[i] = (new Employee(id, name, salary));
                        }

                        Console.Write("Enter the employee id that will have salary increase: ");
                        try {
                            int idSalaryRaise = int.Parse(Console.ReadLine() ?? "");
                            foreach (Employee employee in employees) {
                                if (employee.GetId() == idSalaryRaise) {
                                    Console.Write("Enter the percentage: "); employee.RaiseSalary(double.Parse(Console.ReadLine() ?? ""));
                                    Console.WriteLine();
                                    foundId = true;
                                    break;
                                }
                            }
                        } catch (Exception e) {
                            Console.WriteLine(e.Message);
                        }

                        if (!foundId) { Console.WriteLine("This id does not exist!\n"); }

                        Console.WriteLine("Updated list of employees:");
                        foreach (Employee employee in employees) {
                            Console.WriteLine($"{employee.GetId()}, {employee.GetName()}, {employee.GetSalary()}");
                        }
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Código não encontrado.");
                        break;
                }
                Console.ReadLine();
                
            }

        }

    }

}