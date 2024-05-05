string paragraph = "My name is SULTAN ALI TIPU, Im doing BS in Computer Science from Virtual University also doing job as Assistant Manager in NM Enterprises (Martin-Baker Aircraft Company Limited), I also have experties in MERN Stack and now I have enrolled in dotNet course in EWX institute and I have applied in Cloud Computing course in Government Technical Collage for Rawalpindi.";

// String methods
string[] sentences = paragraph.Split(','); // Split the paragraph into sentences
string upperCaseParagraph = paragraph.ToUpper(); // Convert paragraph to uppercase
string lowerCaseParagraph = paragraph.ToLower(); // Convert paragraph to lowercase
string replacedText = paragraph.Replace("NM Enterprises", "XYZ Enterprises"); // Replace company name
string trimmedParagraph = paragraph.Trim(); // Remove leading and trailing whitespace

// Output results
Console.WriteLine("Original Paragraph:");
Console.WriteLine(paragraph);

Console.WriteLine("\nParagraph Split into Sentences:");
foreach (string sentence in sentences)
{
	Console.WriteLine(sentence.Trim()); // Trim whitespace from each sentence
}

Console.WriteLine("\nUppercase Paragraph:");
Console.WriteLine(upperCaseParagraph);

Console.WriteLine("\nLowercase Paragraph:");
Console.WriteLine(lowerCaseParagraph);

Console.WriteLine("\nReplaced Company Name:");
Console.WriteLine(replacedText);

Console.WriteLine("\nTrimmed Paragraph:");
Console.WriteLine(trimmedParagraph);

Console.ReadLine();