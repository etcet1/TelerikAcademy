/*
 * Write an if statement that examines two integer variables and 
 * exchanges their values if the first one is greater than the second one.
 */

var fisrtNumber = 6;
var secondNumber = 5;

console.log("The initial values are " + fisrtNumber + " and " + secondNumber + ".");

function examineTwoNumbers(fisrtNumber, secondNumber) {
    if (fisrtNumber > secondNumber){
        console.log(fisrtNumber + " is greater than " + secondNumber + ".");
        var tempNumber = fisrtNumber + secondNumber;
        secondNumber = tempNumber - secondNumber;
        fisrtNumber = tempNumber - fisrtNumber;

        console.log("The new value of the first number is " + fisrtNumber + " and the new value of the second number is " + secondNumber);
    } else {
        console.log("The first number is not greater so we will keep the values of the numbers.");
    }
}
(function() {
    ExamineTwoNumbers(fisrtNumber, secondNumber);
})();