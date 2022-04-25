using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerCostApplication {
    class SneakerCost {
        static void Main(string[] args) {
            /* Start the Console print outs for the program */

            Console.WriteLine("Total Revenue of Sneakers");
            Console.WriteLine("Press 1 for Additional Accessories")
            Console.WriteLine("Press 2 for Costs Over Retail");
            Console.WriteLine("Press 3 for Total After Taxes Added");
            Console.WriteLine("Press 4 for Total After Discount");
            
            /* Set up the inputs that can be used for the cost to be calculated */
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Retail Value of Sneaker");
            int value_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Taxes, Discount, or Over Retail Costs");
            int value_2 = Convert.ToInt32(Console.ReadLine());
            int total = 0;

            /* Now we will use the switch function to create various cases
            that will calculate the total revenue of sneakers */

            switch(action) {
                case 1: {
                    total = Addition(value_1, value_2);
                    break;
                }
                case 2: {
                    total = Subtraction(value_1, value_2);
                    break;

                }
                case 3: {
                    total = Multiplication(value_1, value_2);
                    break;
                }
                case 4: {
                    total = Division(value_1, value_2);
                    break;
                }
                default:
                Console.WriteLine("That is not an option");
                break;
            }
            Console.WriteLine("The total revenue is {0}", total);
            Console.ReadKey()
        }
    }
}

    /* Now we will start to write out our equations for our
    calculations */

    /* Gather Total Purchase */

    public static int Addition(int value_1, int value_2) {
        int total = value_1 + value_2;
        return total;
    }

    /* Gather Cost Over Retail */
    public static int Subtraction(int value_1, int value_2) {
        int total = value_1 + value_2;
        return total;
    }

    /* Gather Total After Taxes */
    public static int Multiplication(int value_1, value_2) {
        int total = value_1 + value_2;
        return total;
    }

    /* Gather Total After Discount */
    public static int Division(int value_1, int value_2) {
        int total = value_1 + value_2;
        return total;
    }
}

