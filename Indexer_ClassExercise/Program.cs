// File: Address.cs
using System;

class AddressBook
{
    private string[] names;
    private string[] phones; // add phone numbers
    private int count;

    public AddressBook()
    {
        names = new string[20];
        phones = new string[20]; // add phones array
        count = 0;
    }

    public void Add(string name, string phone) // pass phone as well as name
    {
        names[count] = name;   // set the name into the address book
        phones[count] = phone; // set the phone into the address book
        count++;
    }

    public int Count // read-only property
    {
        get
        {
            return count;
        }
    }

    public string this[int index] // read-only indexer
    {
        get
        {
            return names[index];
        }
    }


    // create a smart indexer that 
    public string this[string name] 
    {
        // we can get the phone number for a given person
        get
        {
            // loop to find the name
            // if a match then return the phone number
            // of the given name

            for(int i = 0; i < Count; i++)
            {
                if(names[i] == name)
                {
                    return phones[i];
                }
                
            }// once loop is done, get looks for a return
            return null;            
        }

        // we can also change the 
        //phone number of the given person

        set
        {
            for (int i = 0; i < Count; i++)
            {
                if (names[i] == name)
                {
                    phones[i] = value; 
                    break;  // once done with the change break out
                }

            }
        }

    }
}

class TestAddressBook
{
    static void Main()
    {
        AddressBook book = new AddressBook();

        book.Add("ABC Plumbing", "206-555-1212");
        book.Add("Mom", "425-123-4567");
        book.Add("Dentist", "360-333-4444");

        // Display all the names of the address book
        for (int i = 0; i < book.Count; i++)
        {
            // book looks like an array but it is really
            // an indexer property on the class that returns
            // the private string[] names[i]

            string name = book[i]; 

            Console.WriteLine("Name = {0}", name); // get
            Console.WriteLine("Phone = {0}", book[name]); //get based on a given name
            
            // change one's phone number
            book["Mom"] = "425-444-5555"; //set based on a given name
            Console.WriteLine("\n\nMy Mom's new phone = {0}", book["Mom"]);

            Console.ReadLine();
        }
    }
}
