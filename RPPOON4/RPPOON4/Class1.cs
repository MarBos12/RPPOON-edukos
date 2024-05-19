public class WebElement
{
    string name;
    public WebElement(string name)
    {
        Console.WriteLine($"{name}");
        this.name = name;
    }
    public void Click()
    {
        Console.WriteLine($"{name}");
    }
}

public interface LoginPage
{
    public WebElement loginButton();
    public WebElement usernameInput();
    public WebElement passwordInput();
}

public abstract class LoginPageFactory
{
    public abstract LoginPage CreatePage();
}
public class ChromeLoginPage : LoginPage
{
    public WebElement loginButton()
    {
        return new WebElement("Chrome Login Button");
    }

    public WebElement usernameInput()
    {
        return new WebElement("Chrome Username Input");
    }

    public WebElement passwordInput()
    {
        return new WebElement("Chrome Password Input");
    }
}
public class ChromeLoginPageFactory : LoginPageFactory
{
    public override LoginPage CreatePage()
    {
        return new ChromeLoginPage();
    }
}
class Program
{
    static void Main(string[] args)
    {
        LoginPageFactory factory = new ChromeLoginPageFactory();
        LoginPage loginPage = factory.CreatePage();

        WebElement loginButton = loginPage.loginButton();
        WebElement usernameInput = loginPage.usernameInput();
        WebElement passwordInput = loginPage.passwordInput();

        usernameInput.Click();
        passwordInput.Click();
        loginButton.Click();
    }
}