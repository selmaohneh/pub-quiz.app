#!/usr/bin/env python3
"""
Script to automatically generate manifest files for all quiz types.
This script scans the quiz directories and creates manifest.json files
containing lists of all quiz files found in each directory.
"""

import json
import os
from pathlib import Path

def update_manifest(quiz_type):
    """Update manifest for a specific quiz type."""
    quiz_dir = Path(f'wwwroot/quizzes/{quiz_type}')
    
    if not quiz_dir.exists():
        print(f"Warning: Directory {quiz_dir} does not exist")
        return
    
    # Get all JSON files except manifest.json
    quiz_files = [f.name for f in quiz_dir.glob('*.json') if f.name != 'manifest.json']
    
    # Sort alphabetically
    quiz_files.sort()
    
    # Write manifest
    manifest_path = quiz_dir / 'manifest.json'
    with open(manifest_path, 'w') as f:
        json.dump(quiz_files, f, indent=2)
    
    print(f"Updated {quiz_type} manifest with {len(quiz_files)} files: {quiz_files}")

def main():
    """Update manifests for all quiz types."""
    quiz_types = ['sort-quiz', 'lie-quiz', 'year-quiz']
    
    for quiz_type in quiz_types:
        update_manifest(quiz_type)

if __name__ == '__main__':
    main() 