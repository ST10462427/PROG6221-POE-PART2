using System;
using System.Media;
using System.Net;



namespace CybersecurityAwarenessChatbot
{
    class Program
    {
        static string userName;
        static string userInterest;
        static Dictionary<string, string> keywordResponses = new Dictionary<string, string>()
        {
            {"password", "Make sure to use strong, unique passwords for each account. Avoid using personal details in your passwords."},
            {"scam", "Be cautious of suspicious emails or messages that ask for sensitive information. Never give out your login credentials or financial information to unknown sources."},
            {"privacy", "Protect your personal data by being mindful of what you share online. Use strong passwords and enable two-factor authentication whenever possible."}
        };

        static string[] phishingTips = new string[]
        {
            "Be cautious of emails asking for personal information. Scammers often disguise themselves as trusted organisations.",
            "Always verify the authenticity of emails and messages before responding or clicking on links.",
            "Phishing attacks often use urgency or threats to trick victims into revealing sensitive information.",
            "Never give out your login credentials or financial information to unknown sources.",
            "Use two-factor authentication to add an extra layer of security to your online accounts."
        };

        static void Main(string[] args)
        {

            if (OperatingSystem.IsWindows())
            {
                SoundPlayer spookyPlayer = new SoundPlayer("voice.text.wav");
                spookyPlayer.Load();
                spookyPlayer.Play();
            }
            // ASCII Art Logo
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                                       ___________");
            Console.WriteLine("                                                       \\         /");
            Console.WriteLine("                                                       W E L C O M E");
            Console.WriteLine("                                                       /         \\");
            Console.WriteLine("                                                       ___________");


            Console.WriteLine("\n");

            Console.WriteLine("                                                         _____");
            Console.WriteLine("                                                        |       |");
            Console.WriteLine("                                                        |  T  O  |");
            Console.WriteLine("                                                        |       |");
            Console.WriteLine("                                                         _____");


            Console.WriteLine("                                         ______________CyberSentinel______________");
            Console.WriteLine("                                        |                                         |");
            Console.WriteLine("                                        |           ___                           |");
            Console.WriteLine("                                        |          /        \\                     |");
            Console.WriteLine("                                        |         /          \\                    |");
            Console.WriteLine("                                        |        |   _  _  |                      |");
            Console.WriteLine("                                        |        |  /  \\/  \\ |                    |");
            Console.WriteLine("                                        |        | |  |  |  |                     |");
            Console.WriteLine("                                        |        | |_|  |_|                       |");
            Console.WriteLine("                                        |        |_______                         |");
            Console.WriteLine("                                        |               ___          \\            |");
            Console.WriteLine("                                        |              /       \\          \\       |");
            Console.WriteLine("                                        |             /         \\          \\      |");
            Console.WriteLine("                                        |            |   CYBER   |          \\     |");
            Console.WriteLine("                                        |            |  SENTINEL  |          \\    |");
            Console.WriteLine("                                        |            |             |          \\   |");
            Console.WriteLine("                                        |            |             |          /   |");
            Console.WriteLine("                                        |            |             |         /    |");
            Console.WriteLine("                                        |             \\           /         /     |");
            Console.WriteLine("                                        |              \\         /         /      |");
            Console.WriteLine("                                        |               \\___/         /           |");
            Console.WriteLine("                                        |                                         |");
            Console.WriteLine("                                        |       Protecting Your Digital World     |");
            Console.WriteLine("                                        |                                         |");
            Console.WriteLine("                                        |______________CyberSentinel______________|");
            Console.WriteLine("                                                   Guardian of the digital world");

            // Get user's name
            Console.Write("Hello! What is your name ? ");
            Console.ForegroundColor = ConsoleColor.Green;
            string userName = Console.ReadLine();


            // Display welcome message
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Welcome, ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{userName}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("! I'm here to help you stay safe online.");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("What's your question? (or type 'exit' to quit) \n \n Type of Question you may ask: \n 1.how are you? \n 2.what's your purpose? \n 3.what can i ask you about? \n 4.password safety \n 5.phishing tips \n 6.safe browsing \n");
                Console.ForegroundColor = ConsoleColor.Green;
                string userQuestion = Console.ReadLine().Trim().ToLower();

                if (userQuestion == "exit")
                {
                    break;
                }

                bool keywordFound = false;
                foreach (var keywordResponse in keywordResponses)
                {
                    if (userQuestion.Contains(keywordResponse.Key))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(keywordResponse.Value);
                        Console.ResetColor();
                        keywordFound = true;
                        break;
                    }
                }

                if (!keywordFound)
                {
                    switch (userQuestion)
                    {
                        case "how are you?":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("I'm doing great, thanks for asking!");
                            Console.ResetColor();
                            break;
                        case "what's your purpose?":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("My purpose is to help you stay safe online by providing cybersecurity tips and advice.");
                            Console.ResetColor();
                            break;
                        case "what can i ask you about?":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("You can ask me about password safety, phishing, safe browsing");
                            Console.ResetColor();
                            break;
                        case "password safety":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n-----------------------------------------------");
                            Console.WriteLine(" Password Safety ");
                            Console.WriteLine("-----------------------------------------------\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Make sure to use strong, unique passwords for each account. Avoid using personal details in your passwords.");
                            Console.ResetColor();
                            break;
                        case "phishing tips":
                        case "phishing":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n-----------------------------------------------");
                            Console.WriteLine(" Phishing Tips ");
                            Console.WriteLine("-----------------------------------------------\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("What is Phishing?\r\n\r\nPhishing is a type of cyber attack where attackers send fake messages, emails, or texts that appear to be from a legitimate source, such as a bank, social media platform, or online retailer. These messages aim to trick victims into revealing sensitive information, such as:\r\n\r\n- Login credentials ( usernames and passwords)\r\n- Financial information (credit card numbers, account numbers)\r\n- Personal data (Social Security numbers, addresses)\r\n\r\nTypes of Phishing Attacks\r\n\r\n1. Email Phishing: The most common type, where attackers send fake emails that appear to be from a legitimate source.\r\n2. Spear Phishing: Targeted attacks where attackers focus on a specific individual or group, often using personalized information to make the message more convincing.\r\n3. Smishing: Phishing attacks sent via SMS or text messages.\r\n4. Vishing: Phishing attacks conducted via voice calls.\r\n5. Angler Phishing: Attackers pose as customer support representatives, often using social media or messaging apps.\r\n\r\nHow to Identify Phishing Attempts\r\n\r\n1. Urgency: Phishing messages often create a sense of urgency, claiming that your account will be closed or compromised if you don't take immediate action.\r\n2. Spelling and Grammar: Phishing messages often contain spelling and grammar mistakes.\r\n3. Suspicious Links: Phishing messages may contain links that don't match the supposed sender's website.\r\n4. Attachments: Phishing messages may contain attachments that contain malware.\r\n5. Unusual Requests: Phishing messages may ask for sensitive information that the supposed sender wouldn't normally request.");
                            Random random = new Random();
                            string tip = phishingTips[random.Next(phishingTips.Length)];
                            Console.WriteLine("\nHere's a phishing tip to keep in mind:");
                            Console.WriteLine(tip);
                            Console.ResetColor();
                            break;
                        case "safe browsing":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n-----------------------------------------------");
                            Console.WriteLine(" Safe Browsing ");
                            Console.WriteLine("-----------------------------------------------\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("What is Safe Browsing?\r\n\r\nSafe browsing refers to the practices and techniques used to protect yourself from online threats and malicious activities while browsing the internet. This includes protecting your personal data, preventing malware infections, and avoiding phishing scams.\r\n\r\nTypes of Online Threats\r\n\r\n1. Malware: Malicious software designed to harm your device or steal your data.\r\n2. Phishing: Scams that trick you into revealing sensitive information.\r\n3. Drive-by Downloads: Malware downloaded onto your device without your knowledge or consent.\r\n4. Man-in-the-Middle (MitM) Attacks: Hackers intercepting your online communications.\r\n\r\nBest Practices for Safe Browsing\r\n\r\n1. Keep Your Browser Up-to-Date: Regularly update your browser to ensure you have the latest security patches.\r\n2. Use Strong Antivirus Software: Install reputable antivirus software to protect against malware.\r\n3. Avoid Suspicious Links: Be cautious when clicking on links from unknown sources.\r\n4. Verify Website Authenticity: Check for \"https\" and a lock icon in the address bar to ensure a secure connection.\r\n5. Use a VPN: Consider using a virtual private network (VPN) to encrypt your online traffic.\r\n6.Be Cautious with Public Wi - Fi: Avoid accessing sensitive information on public Wi-Fi networks.\r\n7.Use a Reputable Ad Blocker: Consider using an ad blocker to reduce the risk of malware infections.\r\n8.Clear Browser Cache and Cookies: Regularly clear your browser cache and cookies to remove stored data.");
                            Console.ResetColor();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("I am not following what you are saying, could you rephrase? Please!");
                            Console.ResetColor();
                            break;
                    }
                }
            }
        }
    }
}

