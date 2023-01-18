namespace HeistConsole;

//the job of this class is to handle collecting info and creating new team members
public class TeamMemberBuilder
{
    public void Run()
    {
        /*  Phase 1
    1. Print the message "Plan Your Heist!".
    2. Create a way to store a single team member. A team member will have a *name*, a *skill Level* and a *courage factor*. The *skill Level* will be a positive integer and the *courage factor* will be a decimal between 0.0 and 2.0.
    3. Prompt the user to enter a team member's name and save that name.
    4. Prompt the user to enter a team member's skill level and save that skill level with the name.
    5. Prompt the user to enter a team member's courage factor and save that courage factor with the name.
    6. Display the team member's information.
*/

        // Part 1
        Console.Write("Plan Your Heist!");

        TeamMember teamMember = new TeamMember();

        Console.WriteLine("Enter name: ");
        teamMember.Name = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(teamMember.Name))
        {
            Console.WriteLine("Name cannot be blank: ");
            teamMember.Name = Console.ReadLine();
        }

        Console.WriteLine("Enter skill level: ");
        string skillInput = Console.ReadLine();
        int skillAsInt = -1;

        do
        {
            try
            {
                teamMember.SkillLevel = skillAsInt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                skillInput = Console.ReadLine();
            }
        } while (!int.TryParse(skillInput, out skillAsInt));

        teamMember.SkillLevel = skillAsInt;

        Console.WriteLine("Enter courage factor: ");
        string courageInput = Console.ReadLine();
        //|| courageAsDec < 0m || courageAsDec > 2m
        while (!decimal.TryParse(courageInput, out decimal courageAsDec))
        {
            Console.WriteLine("Courage must be between 0.0 and 2.0: ");
            courageInput = Console.ReadLine();
            teamMember.CourageFactor = courageAsDec;
        }

        Console.WriteLine(teamMember);
    }

    private bool ValidSkillInput(int input)
    {

        return input <= 0;
    }
}
