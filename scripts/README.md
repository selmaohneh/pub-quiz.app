# Quiz Manifest Update System

This directory contains scripts for automatically managing quiz manifest files.

## Overview

The quiz manifest system automatically generates `manifest.json` files for each quiz type by scanning the quiz directories and creating lists of all available quiz files.

## Files

- `update-manifests.py` - Python script that scans quiz directories and generates manifest files
- `README.md` - This documentation file

## How it works

The `update-manifests.py` script:

1. Scans each quiz directory (`sort-quiz`, `lie-quiz`, `year-quiz`)
2. Finds all `.json` files (excluding `manifest.json` itself)
3. Sorts the filenames alphabetically
4. Writes a `manifest.json` file containing the list of quiz files

## Manual Usage

To manually update all manifests:

```bash
python3 scripts/update-manifests.py
```

## GitHub Action

The GitHub Action (`.github/workflows/update-manifests.yml`) automatically runs:

- **Every hour** via cron schedule
- **Manually** via workflow dispatch

The action:
1. Checks out the repository
2. Runs the manifest update script
3. Commits and pushes any changes

## Quiz Types

Currently supported quiz types:
- `sort-quiz` - Sorting quizzes
- `lie-quiz` - True/false quizzes  
- `year-quiz` - Year-based quizzes

## Adding New Quiz Types

To add a new quiz type:

1. Create the quiz directory: `wwwroot/quizzes/new-quiz-type/`
2. Add the quiz type to the `quiz_types` list in `update-manifests.py`
3. The manifest will be automatically generated on the next run

## Manifest Format

Each manifest file contains a JSON array of quiz filenames:

```json
[
  "quiz-file-1.json",
  "quiz-file-2.json",
  "quiz-file-3.json"
]
``` 