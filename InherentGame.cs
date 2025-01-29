using System;
using System.Windows.Forms;

public class QuizGame : Form
{
    private int currentScenario = 0;
    private int score = 0;
    private bool showResult = false;
    private List<Scenario> scenarios;

    public QuizGame()
    {
        // Initialize scenarios with text and answer data
        scenarios = new List<Scenario>()
        {
            new Scenario("The government imposes an excise tax on luxury goods.", "Taxation"),
            // Add other scenarios here...
        };

        // Create UI elements for the quiz (labels, buttons, etc.)
        // ...

        // Wire up button click events to handle answer selection
        // ...
    }

    private void HandleAnswer(string choice)
    {
        var isCorrect = choice == scenarios[currentScenario].answer;

        if (isCorrect)
        {
            score++;
            // Show confetti animation (replace with equivalent C# logic)
            // ...
        }
        else
        {
            // Show incorrect answer feedback (change color, display emoji)
            // ...
        }

        // Update UI to display feedback and next scenario (or final score)
        // ...

        currentScenario++;
        if (currentScenario == scenarios.Count)
        {
            showResult = true;
        }
    }

    // ... other methods for updating UI and game logic ...
}

public class Scenario
{
    public string Text { get; set; }
    public string Answer { get; set; }

    public Scenario(string text, string answer)
    {
        Text = text;
        Answer = answer;
    }
}

public static void Main(string[] args)
{
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    Application.Run(new QuizGame());
}