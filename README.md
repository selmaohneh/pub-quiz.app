# 🍻 Pub Quiz App

A fun, interactive web application for hosting pub quizzes with friends! Create custom quizzes and challenge your knowledge with two exciting game modes.

🎮 **[Play Now](https://pub-quiz.io)** | 🔒 **[Privacy Policy](PRIVACY.md)**

## 🎯 Game Modes

### 📋 Sort Quiz
Test your knowledge by sorting items in the correct order! Perfect for:
- Historical events by date
- Countries by population
- Movies by box office earnings
- Animals by size
- And much more!

**How to play:**
1. One random item is pre-placed
2. Drag or click remaining items to sort them
3. Place items in the correct order from top to bottom
4. First wrong placement ends the game!

### 📅 Year Quiz
Guess the year of historical events with increasing difficulty over time!

**How to play:**
1. A historical event is displayed
2. Watch the timer - every 10 seconds the acceptable range increases (±0, ±1, ±2...)
3. Stop the timer and make your guess
4. Win if you're within the current range!

## 🚀 Getting Started

### Playing Quizzes
1. Visit [pub-quiz.io](https://pub-quiz.io)
2. Choose your game mode
3. Download a template or use existing quizzes from the `/quizzes` folder
4. Upload your JSON file and start playing!

### Running Locally
```bash
# Clone the repository
git clone https://github.com/selmaohneh/pub-quiz.app.git
cd pub-quiz.app

# Run the application
dotnet run

# Open your browser to http://localhost:5240
```

## 📁 Quiz Collection

We maintain a growing collection of community-created quizzes in the `/quizzes` folder:

- **`/quizzes/sort-quiz/`** - Sort-based quizzes
- **`/quizzes/year-quiz/`** - Year-based historical quizzes

## 🎨 Creating Your Own Quizzes

### Sort Quiz Format
```json
{
  "title": "Your Quiz Title",
  "upperLabel": "Highest/First",
  "lowerLabel": "Lowest/Last", 
  "hint": "Sort from upperLabel to lowerLabel",
  "items": [
    "Item 1 (first in order)",
    "Item 2", 
    "Item 3 (last in order)"
  ]
}
```

### Year Quiz Format
```json
{
  "title": "Historical Events Quiz",
  "hint": "Guess the year these events happened",
  "items": [
    {
      "title": "Fall of the Berlin Wall",
      "year": 1989
    },
    {
      "title": "First Moon Landing", 
      "year": 1969
    }
  ]
}
```

## 🤝 Contributing Quizzes

**We'd love your quiz contributions!** Here's how to add your quizzes:

### 📝 Submission Guidelines

1. **Fork this repository**
2. **Add your quiz file** to the appropriate folder:
   - Sort quizzes → `/quizzes/sort-quiz/`
   - Year quizzes → `/quizzes/year-quiz/`
3. **Use descriptive filenames** (e.g., `european-capitals-by-population.json`)
4. **Test your quiz** by uploading it to the app
5. **Submit a pull request** with a brief description

### ✅ Quality Guidelines

- **Accurate data**: Ensure all information is correct
- **Appropriate difficulty**: Not too easy, not impossibly hard
- **Clear titles**: Use descriptive, unambiguous item names
- **Reasonable length**: 5-30 items for sort quizzes
- **Family-friendly**: Keep content appropriate for all ages
- **Original content**: Don't copy copyrighted quiz materials

### 💡 Quiz Ideas

**Sort Quiz Topics:**
- Countries by area/population/GDP
- Movies by release date/box office
- Historical events chronologically  
- Books by publication date
- Sports records and achievements
- Geographic features by size
- Scientific discoveries by date

**Year Quiz Topics:**
- Historical events
- Invention dates
- Movie/book releases
- Scientific breakthroughs
- Political milestones
- Cultural phenomena

## 🛠️ Technical Details

- **Framework**: Blazor WebAssembly (C#)
- **Hosting**: Static hosting compatible
- **Analytics**: Privacy-friendly Plausible.io
- **No Backend**: All processing happens in your browser
- **No Data Collection**: Your quiz data never leaves your device

## 🔒 Privacy

We respect your privacy! We only collect anonymous analytics via Plausible.io to understand usage patterns. No personal data, quiz content, or tracking cookies are used. See our [Privacy Policy](PRIVACY.md) for full details.

## 📞 Contact

- **Email**: [pub-quiz@neumann.sh](mailto:pub-quiz@neumann.sh)
- **Issues**: [GitHub Issues](https://github.com/selmaohneh/pub-quiz.app/issues)

## 📜 License

This project is open source. Feel free to use, modify, and distribute according to the license terms.

---

**Ready to test your knowledge? [Start playing now!](https://pub-quiz.io)** 🎉 