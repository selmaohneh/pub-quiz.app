# 🍻 Pub Quiz App

A fun, interactive web application for hosting pub quizzes with friends! Create custom quizzes and challenge your knowledge with four exciting game modes.

🎮 **[Play Now](https://www.pub-quiz.app)** | 🔒 **[Privacy Policy](PRIVACY.md)**

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

### 🔗 Pair Quiz
Match pairs that belong together! Test your knowledge of connections and relationships.

**How to play:**
1. Two columns of items are displayed - left and right
2. Click on items from each column to match them
3. Find all correct pairs to win
4. One extra item is included to make the last match challenging!

### 🤥 Who Lies?
Spot the lies among the truths! Perfect for team competition and fast thinking.

**How to play:**
1. A question or topic is shown
2. Statements appear one by one every 10 seconds
3. Teams compete to click "That's a Lie!" when they spot a false statement
4. First team to correctly identify a lie gets a point!

## 🚀 Getting Started

### Playing Quizzes
1. Visit [www.pub-quiz.app](https://www.pub-quiz.app)
2. Choose your game mode
3. Download a template or use existing quizzes from the `/wwwroot/quizzes` folder
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

## 🎉 Quiz Night Guide

Ready to host a complete quiz night with friends? We've included a comprehensive Quiz Night Guide that covers:
- 📋 Preparation tips and setup instructions
- 🎮 Game rules and scoring systems  
- 🍕 Food & drinks ideas for your event
- 🏆 Tips for making your quiz night memorable

Access the guide directly in the app or visit `/quiz-night-guide` for the complete hosting experience!

## 📁 Quiz Collection

We maintain a growing collection of community-created quizzes in the `/wwwroot/quizzes` folder:

- **`/quizzes/sort-quiz/`** - Sort-based quizzes (16 available)
- **`/quizzes/year-quiz/`** - Year-based historical quizzes (3 available)
- **`/quizzes/pair-quiz/`** - Matching pair quizzes (3 available)
- **`/quizzes/lie-quiz/`** - Truth vs lie quizzes (2 available)

## 🎨 Creating Your Own Quizzes

### Sort Quiz Format
```json
{
  "title": "Your Quiz Title",
  "upperLabel": "Highest/First",
  "lowerLabel": "Lowest/Last", 
  "description": "Sort from upperLabel to lowerLabel",
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
  "description": "Guess the year these events happened",
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

### Pair Quiz Format
```json
{
  "title": "Animals and Their Sounds",
  "leftLabel": "Animals",
  "rightLabel": "Sounds",
  "description": "Match each animal with the sound they make",
  "pairs": [
    {
      "left": "Dog",
      "right": "Bark"
    },
    {
      "left": "Cat",
      "right": "Meow"
    }
  ],
  "additionalRightItem": "Hiss"
}
```

### Lie Quiz Format
```json
{
  "title": "Oscar Winners",
  "question": "Has a Best Actor Oscar",
  "description": "These are actors who have won the Academy Award for Best Actor",
  "items": [
    {
      "name": "Daniel Day-Lewis",
      "isLie": false
    },
    {
      "name": "Ian McKellen",
      "isLie": true
    }
  ]
}
```

## 🤝 Contributing Quizzes

**We'd love your quiz contributions!** Here's how to add your quizzes:

### 📝 Submission Guidelines

1. **Fork this repository**
2. **Add your quiz file** to the appropriate folder:
   - Sort quizzes → `/wwwroot/quizzes/sort-quiz/`
   - Year quizzes → `/wwwroot/quizzes/year-quiz/`
   - Pair quizzes → `/wwwroot/quizzes/pair-quiz/`
   - Lie quizzes → `/wwwroot/quizzes/lie-quiz/`
3. **Update the manifest.json** in the appropriate folder to include your quiz
4. **Use descriptive filenames** (e.g., `european-capitals-by-population.json`)
5. **Test your quiz** by uploading it to the app
6. **Submit a pull request** with a brief description

### ✅ Quality Guidelines

- **Accurate data**: Ensure all information is correct
- **Appropriate difficulty**: Not too easy, not impossibly hard
- **Clear titles**: Use descriptive, unambiguous item names
- **Reasonable length**: 5-30 items for sort quizzes, 10-20 pairs for pair quizzes
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

**Pair Quiz Topics:**
- Countries and capitals
- Authors and books
- Movies and directors
- Elements and symbols
- Landmarks and cities
- Foods and countries

**Lie Quiz Topics:**
- Celebrity facts
- Historical claims
- Scientific statements
- Geographic facts
- Sports records
- Movie trivia

## 🛠️ Technical Details

- **Framework**: Blazor WebAssembly with .NET 8.0
- **Architecture**: Client-side Single Page Application (SPA)
- **Hosting**: Static hosting compatible (GitHub Pages, Netlify, etc.)
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

**Ready to test your knowledge? [Start playing now!](https://www.pub-quiz.app)** 🎉 
