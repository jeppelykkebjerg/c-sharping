Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

string rule2_message = "Your subscription will expire soon. Renew now!";
string rule3_message = $"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!";
string rule4_message = $"Your subscription expires within a day!\nRenew now and save 20%!";
string rule5_message = "Your subscription has expired.";

if (daysUntilExpiration == 0) {
    Console.WriteLine(rule5_message);
} else if (daysUntilExpiration < 2) {
    Console.WriteLine(rule4_message);
} else if (daysUntilExpiration <= 5) {
    Console.WriteLine(rule3_message);
} else if (daysUntilExpiration <= 10) {
    Console.WriteLine(rule2_message);
}