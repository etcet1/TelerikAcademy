/*
 * Write a script that finds the biggest of three integers using nested if statements.
 */

(function() {
    var firstNumber = 3;
    var secondNumber = 7;
    var thirdNumber = 2;

    console.log("The first number is:" + firstNumber);
    console.log("The second number is:" + secondNumber);
    console.log("The third number is:" + thirdNumber);

    if (firstNumber > secondNumber && firstNumber > thirdNumber) {
        console.log("The first number " + firstNumber + " is the biggest one.");
    }
    else if (secondNumber > firstNumber && secondNumber > thirdNumber) {
        console.log("The second number " + secondNumber + " is the biggest one.");
    }
    else if (thirdNumber > firstNumber && thirdNumber > secondNumber) {
        console.log("The third number " + thirdNumber + " is the biggest one.");
    }
    else if (firstNumber === secondNumber || secondNumber === thirdNumber || firstNumber === thirdNumber) {
        console.log("At least two of the numbers are equal.");
    }
})();