

namespace Lab4
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            //Lists of objects used to store the data
            List<Phone> phones = new List<Phone>();
            List<Address> addresses = new List<Address>();
            List<Person> people = new List<Person>();


            using (StreamReader sr = new StreamReader(FileRoot.Root + "/data.csv"))
            {
                try
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] elements = line.Split(",");
                         
                        //removes the quotation marks
                        for (int i = 0; i < elements.Length; i++)
                        {
                            elements[i] = elements[i].Replace("\"", "");
                        }

                        
                         //for each row in elements, create a new phone object. 
                         //phoneParts array divides elements index 9 into 3 parts as to divide the number into area, exchange, and line numbers
                         //gives index out of bound error...
                        for (int i = 0; i < elements.Length; i++)
                        {
                            string[] phoneParts = elements[9].Split("-");
                            phones.Add(new Phone( "1", phoneParts[0], phoneParts[1], phoneParts[2],("1-" + elements[9])));
                        }

                        //same concept as the phones loop
                        for( int i = 0; i < elements.Length; i++)
                        {
                            string[] streetAddresses = elements[3].Split(" ");
                            addresses.Add(new Address(streetAddresses[0], streetAddresses[1], elements[4], elements[6], elements[7]));
                        }

                        //loop that uses previous loops to create a person abject
                        for (int i = 0; i < elements.Length; i++)
                        {
                            people.Add(new Person(elements[0], elements[1], addresses[i], phones[i]));
                        }

                    }

                    //file writer that writes each person object to data file using '\' as a delimiter
                    using (StreamWriter sw = new StreamWriter(FileRoot.Root + "/data.psv.xlsx"))
                    {
                            foreach (Person p in people)
                            {
                                sw.WriteLine(p.ToString());
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            



        }
    }
}