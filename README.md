# Near Earth Object Web Service C# GUI
This project is a simple C# GUI application that allows users to request a single day period using NeoWs to find Asteroids or Comets and their closest approach date to Earth, their relative velocity, and much more.

## Table of Contents
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgements](#acknowledgements)

## Installation

To be determined.

## Usage

* In the top-left corner of the application, observe the “Retrieve Data” group box.
* Input a date in the correct format of YYYY-MM-DD.
  * You may choose to click the “Search” button below at this point to select the current date by default.
  * Leaving the text box empty or with white space will also select the current date by default.
  * Inputting an incorrect date will prompt an error window, as well as writing the error message and a timestamp to error_log.txt in the same directory.
* Once a date has been added, click the “Search” button to update the list.
  * A message box will appear once the search is complete.
* The “Element Count” shows how many small body objects are on their closest approach date on the specified day.
* Below the “Element Count” label are the names of the small body objects.
* By clicking on the name of a small body object on this list, then clicking on the “Show Information” button below it, the right side of the application will populate with numbers.
* The user will now be able to peruse the data for that specific object.
  *The user can also click on another object in the list, and click the “Show Information” button again to replace these values.
  *The user can also enter another date and click “Search” to repopulate the list.
* Once the “Show Information” button is clicked, the link label in the center-left will update, and clicking it will lead to the NASA small body database for further information.
* For more information on the data, hover the mouse over the label of textBox to see the tooltips.

## Contributing

To be determined.

## License

To be determined.

## Acknowledgements

- Thanks to [SpaceRocks Team](https://api.nasa.gov/) for providing the NeoWs API.
