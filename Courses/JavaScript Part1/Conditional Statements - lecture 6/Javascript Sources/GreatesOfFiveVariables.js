/*
 * Write a program that finds the greatest of given 5 variables.
 */

(function() {
    var firstNumber = 6,
        secondNumber = 45,
        thirdNumber = 2,
        fourthNumber = 123,
        fifthNumber = 55;

    if (firstNumber > secondNumber && firstNumber > thirdNumber && firstNumber > fourthNumber && firstNumber > fifthNumber) {
        console.log("\nThe greatest number is" + firstNumber);
    }
    else if (secondNumber > firstNumber && secondNumber > thirdNumber && secondNumber > fourthNumber && secondNumber > fifthNumber) {
        console.log("\nThe greatest number is " + secondNumber);
    }
    else if (thirdNumber > firstNumber && thirdNumber > secondNumber && thirdNumber > fourthNumber && thirdNumber > fifthNumber) {
        console.log("\nThe greatest number is " + thirdNumber);
    }
    else if (fourthNumber > firstNumber && fourthNumber > secondNumber && fourthNumber > thirdNumber && fourthNumber > fifthNumber) {
        console.log("\nThe greatest number is " + fourthNumber);
    }
    else if (fifthNumber > firstNumber && fifthNumber > secondNumber && fifthNumber > thirdNumber && fifthNumber > fourthNumber) {
        console.log("\nThe greatest number is " + fifthNumber);
    } else {
        console.log("\nAt least two numbers are equal and have the same greatest value.");
    }
})();