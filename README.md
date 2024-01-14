# Resume mixer

## Overview

The CV Generator Console App is a prototype application written in C# to automate the creation of a CV based on a list of skills, descriptions, and relevant work experiences. The application uses keyword matching to identify and extract pertinent information from user-provided input.

## Features

- **Keyword Matching:** Leverages keyword matching to identify relevant skills and experiences from the user-provided input.

- **Customization:** Users can input their skills, descriptions, and experiences using simple text files, providing a customizable and user-friendly experience.

- **Automatic CV Generation:** Generates a structured CV backbone based on the provided input, simplifying the process of further customization.

## Prerequisites

- **.NET SDK:** Ensure that you have the .NET SDK installed on your machine. If not, you can download it [here](https://dotnet.microsoft.com/download).

## Installation

1. **Clone the repository:**

    ```bash
    git clone https://github.com/arise-project/resume_mixer.git
    ```

2. **Navigate to the project directory:**

    ```bash
    cd resume_mixer
    ```

3. **Build the App:**

    ```bash
    dotnet build
    ```

## Usage

1. **Prepare Input Files:**
    - Create a text file for your skills with each skill on a new line.
    - Create a text file for your experiences with keywords related to each experience.

2. **Run the App:**

    ```bash
    dotnet run -- --skillsFile skills.txt --experienceFile experience.txt --positionFile position.txt
    ```

    - Replace `skills.txt`, `experience.txt`, and `position.txt` with the paths to your input files.

3. **Generated CV:**
    - The app will generate a CV backbone based on your skills and experiences, customized for the specified job position.

## Example

```bash
dotnet run -- --skillsFile my_skills.txt --experienceFile my_experience.txt --positionFile job_position.txt


https://jdhao.github.io/2019/05/30/markdown2pdf_pandoc/

[!["Buy Me A Coffee"](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/epirogov)

[Responding to recruiter emails with GPT-3](https://matthewbilyeu.com/blog/2022-09-01/responding-to-recruiter-emails-with-gpt-3)

[Resume Matcher] (https://github.com/srbhr/Resume-Matcher)
Resume Matcher is an AI Based Free & Open Source Tool. To tailor your resume to a job description. Find the matching keywords, improve the readability and gain deep insights into your resume.
