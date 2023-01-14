using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeistConsole;

public class TeamMember
{
    //access modifier, determines where this code can be used from
    // public means that property is accessible outside of the class
    // private means it is only accessible inside the class

    //classes have MEMBERS, there are 3 basic types of members:
    //PROPERTIES
    private bool _invalidEntry;

    public string Name { get; set; }
    public int SkillLevel
    {
        get { return SkillLevel; }
        set
        {
            if (value > 0)
            {
                SkillLevel = value;
                _invalidEntry = false;
            }
            else
            {
                _invalidEntry = true;
            }
        }
    }

    public decimal CourageFactor { get; set; }

    public bool HasValidName()
    {
        return string.IsNullOrWhiteSpace(Name);
    }

    //FIELD - private property
    //private string _correctPassword = "password123";

    //METHODS - behavior and functionality
    //public void LogIn()
    //{
    //    Console.WriteLine("what's your password?");
    //    string input = Console.ReadLine();
    //    if (input != _correctPassword)
    //    {
    //        Console.WriteLine("WRONG");
    //    }
    //}


}

//public class OldStyle
//{
//    //OldStyle style = new OldStyle();
//    //style.Name = "Brian"
//    private string _actualNameInput = " Brian   ";

//    //public void SetName(string name)
//    //{
//    //    _name = name;
//    //}
//    public string Name
//    {
//        get
//        {
//            return _actualNameInput.Trim();
//        }
//        set
//        {
//            _actualNameInput = value;
//        }
//    }

//    private int _age;

//    public int Age
//    {
//        get { return _age; }
//        set { _age = value; }
//    }

//    public bool ValidInput()
//    {
//        return string.IsNullOrWhiteSpace(_actualNameInput);
//    }

//    public void Something(string name)
//    {

//    }

//    public void Validate()
//    {

//    }
//}
