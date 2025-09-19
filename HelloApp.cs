namespace ivy.startup.Apps;

[App(icon:Icons.PartyPopper, title:"Hello")]
public class HelloApp : ViewBase
{
    public override object? Build()
    {
        var nameState = this.UseState<string>("Sergey");

        return Layout.Center()
               | (new Card(
                   Layout.Vertical().Gap(6).Padding(2)
                   | new Confetti(new IvyLogo())
                   | Text.H2("Hello " + (string.IsNullOrEmpty(nameState.Value) ? "there" : nameState.Value) + "!")
                   | Text.Block("Welcome to the fantastic world of Ivy. Let's build something amazing together!")
                   | nameState.ToInput(placeholder: "What is your name?")
                   | new Separator()
                   | Text.Markdown("You'd be a hero to us if you could ⭐ us on [Github](https://github.com/Ivy-Interactive/Ivy-Framework)")
                   | Text.H2("Hello Niels")
                   | Text.Block("I'm Sergey Karpov from Westchester, NY")
                   | Text.Block("Very pleased to see your invitation and hope for a productive work promoting Ivy worldwide!")
                   | Text.Markdown("I've placed my introductory Ivy application [here at my Github](https://github.com/SergeyKarpov914/Ivy)")
                 )
                 .Width(Size.Units(120).Max(500)));


    }
}