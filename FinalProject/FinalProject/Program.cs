// IT Fdn Class Project using Template.cs


using System;
struct ItemData   // struct to keep the inventory
{
    public int itemIDNo;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;
}


class MyInventory
{
    public static void Main()
    {

        var icount = 0; // interger to keep track of the count of items in your inventory
        var idata = new ItemData[100];  // array of your ItemData struct
        bool p = true;

        while (p == true) //  loop that shows the user what options they can select until they select quit
        {
            // show what user can select from the list
            Console.Write("\n \n A)dd an item \n M)odify an item \n D)elete an item \n L)ist all items\n I)tems below certain quantity \n Q)uit");
            Console.Write("\n \n Please choose an option from the list (A, M, D, L, I, Q):");
            var optx = Console.ReadLine();
            Console.WriteLine(); // provide an extra blank line on screen

            // read the user's input and then create what case it falls
            switch (optx)
            {
                case "A":   // add an item to the list if this option is selected
                case "a":   // add an item to the list if this option is selected
                    {
                        Console.Write("Item ID Number :");
                        string inum = Console.ReadLine();
                        int itemidnum = int.Parse(inum);

                        Console.Write("Description :");
                        var descrip = Console.ReadLine();

                        Console.Write("Price per item :");
                        string priceperitem = Console.ReadLine();
                        double ppi = double.Parse(priceperitem);

                        Console.Write("Quantity:");
                        string quant = Console.ReadLine();
                        int qty = int.Parse(quant);

                        Console.Write("Cost:");
                        string costperitem = Console.ReadLine();
                        double cost = double.Parse(costperitem);

                        // Always add the item at the end of the array

                        idata[icount].itemIDNo = itemidnum;
                        idata[icount].sDescription = descrip;
                        idata[icount].dblPricePerItem = ppi;
                        idata[icount].iQuantityOnHand = qty;
                        idata[icount].dblOurCostPerItem = cost;
                        idata[icount].dblValueOfItem = ppi * qty;


                        icount++;
                        break;
                    }

                case "M":   //change items in the list if this option is selected
                case "m":   //change items in the list if this option is selected
                    {
                        Console.Write("Please enter an item ID No:");
                        string strchgid = Console.ReadLine();
                        int chgid = int.Parse(strchgid);
                        bool fFound = false;

                        for (int x = 0; x < icount; x++)  // look for the item selected with this loop
                        {
                            if (idata[x].itemIDNo == chgid)
                            {
                                // when found, prompt for the new values

                                fFound = true;
                                Console.Write("New Description :");
                                var descrip = Console.ReadLine();

                                Console.Write("New Price per item :");
                                string priceperitem = Console.ReadLine();
                                double ppi = double.Parse(priceperitem);

                                Console.Write("New Quantity:");
                                string quant = Console.ReadLine();
                                int qty = int.Parse(quant);

                                Console.Write("New Cost:");
                                string costperitem = Console.ReadLine();
                                double cost = double.Parse(costperitem);

                                // save the new data

                                idata[x].sDescription = descrip;
                                idata[x].dblPricePerItem = ppi;
                                idata[x].iQuantityOnHand = qty;
                                idata[x].dblOurCostPerItem = cost;
                                idata[x].dblValueOfItem = ppi * qty;
                            }
                        }

                        if (!fFound) // and if not found let the user know the item was not found
                        {
                            Console.WriteLine("Item {0} not found", chgid);
                        }

                        break;
                    }

                case "D": //delete items in the list if this option is selected
                case "d": //delete items in the list if this option is selected

                    {
                        if (icount == 0) // if there are no items in the array, let user know it is not possible to delete
                        {
                            Console.WriteLine("No items");
                            break;
                        }

                        // prompt for the item to be deleted using the index, not the ItemID

                        Console.Write("Which item to remove (1-{0})", icount);

                        var strnewid = Console.ReadLine();
                        var indexToDelete = int.Parse(strnewid);
                        bool fDeleted = false;


                        for (var x = indexToDelete - 1; x < icount; x++)
                        {
                            // Just copy from the next index into the current index
                            idata[x] = idata[x + 1];
                        }

                        // We have one less item in the array and need to decrease the counter
                        icount--;
                        fDeleted = true;

                        if (fDeleted) // hint the user that you deleted the requested item
                        {
                            Console.WriteLine("Item deleted");
                        }
                        else // if did not find it, hint the user that you did not find it in your list
                        {
                            Console.WriteLine("Item {0} not found", strnewid);
                        }

                        break;
                    }


                case "L":    //list all items in current database if this option is selected
                case "l":    //list all items in current database if this option is selected
                    {
                        if (icount == 0)
                        {
                            Console.WriteLine("No items");
                        }


                        Console.WriteLine("Item# ItemID  Description           Price  QOH  Cost  Value");
                        Console.WriteLine("----- ------  --------------------  -----  ---  ----  -----");



                        for (int index = 0; index < icount; index++)
                        {
                            Console.WriteLine("{0, -5} {1, -7} {2, -20}  {3:C}  {4, 3} {5:C} {6:C}  ", index + 1, idata[index].itemIDNo, idata[index].sDescription, idata[index].dblPricePerItem, idata[index].iQuantityOnHand, idata[index].dblOurCostPerItem, idata[index].dblValueOfItem);
                        }

                        break;
                    }

                case "I":    //list all items in current database that are below certain quantity selected by the user
                case "i":    //list all items in current database that are below certain quantity selected by the user
                    {
                        if (icount == 0)
                        {
                            Console.WriteLine("No items");
                        }

                        Console.Write("Please enter the benchmark quantity you want (below of which will be listed):");
                        string strquant = Console.ReadLine();
                        int quant = int.Parse(strquant);


                        Console.WriteLine("Item# ItemID  Description           Price  QOH  Cost  Value");
                        Console.WriteLine("----- ------  --------------------  -----  ---  ----  -----");



                        for (int index = 0; index < icount; index++)
                        {
                            if (idata[index].iQuantityOnHand < quant)
                            {
                                Console.WriteLine("{0, -5} {1, -7} {2, -20}  {3:C}  {4, 3} {5:C} {6:C}  ", index + 1, idata[index].itemIDNo, idata[index].sDescription, idata[index].dblPricePerItem, idata[index].iQuantityOnHand, idata[index].dblOurCostPerItem, idata[index].dblValueOfItem);
                            }
                        }

                        break;
                    }


                case "Q":  //quit the program if this option is selected
                case "q":  //quit the program if this option is selected
                    {
                        Console.Write("Are you sure that you want to quit(y/n)?");
                        string strresp = Console.ReadLine();

                        if (strresp == "y")
                        {
                            p = false;  //as long as it is not "y", the process is not breaking	
                        }
                        break;
                    }

                default:
                    {
                        Console.Write("Invalid Option, try again");
                        break;
                    }
            }
        }
    }
}