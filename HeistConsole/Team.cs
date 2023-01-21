namespace HeistConsole;

public class Team //purpose: handle adding team members and to keep the team grouped as a unit
{
    public Team()
    {
       
    }

    private TeamMemberBuilder _memberBuilder;
    private List<TeamMember> _members;

    public void Build() 
    {
        Console.WriteLine("Plan Your Heist!");
        Console.WriteLine();

        bool building = true;

        do
        {
            TeamMember newMember = _memberBuilder.Run();
            if (string.IsNullOrWhiteSpace(newMember.Name))
            {
                building = false;
            }
            else
            {
                Console.WriteLine($"Adding {newMember.Name} to the team!");
                Console.WriteLine();
                _members.Add(newMember);
            }

        } while (building);

    }

    public void DisplayTeamInfo()
    {
        Console.WriteLine($"There are {_members.Count} members in the team.");

        _members.ForEach(member => Console.WriteLine(member));
        
        //foreach (TeamMember member in Members)
        //{
        //    Console.WriteLine(member);
        //}
    }
}
