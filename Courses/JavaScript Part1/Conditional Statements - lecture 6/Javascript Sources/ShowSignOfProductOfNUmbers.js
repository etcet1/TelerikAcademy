/*
 * Write a program that shows the sign (+ or -) of the product of three
 * real numbers without calculating it. Use a sequence of if statements.
 */

(function() {
    var firstNumber = 3;
    var secondNumber = -21;
    var thirdNumber = 15;

    console.log("The first number is:" + firstNumber);
    console.log("The second number is:" + secondNumber);
    console.log("The third number is:" + thirdNumber);

     //  ShowSignOfProductOfNumbers
    if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0) {
        console.log("The product of the three numbers " + firstNumber + "," + secondNumber + " and " + thirdNumber + " is with sign \"+\"");
    }
    else if (firstNumber === 0 || secondNumber === 0 || thirdNumber === 0) {
        console.log("The product of the three numbers " + firstNumber + "," + secondNumber + " and " + thirdNumber + " is 0.");
    }
    else {
        console.log("The product of the three numbers " + firstNumber + "," + secondNumber + " and " + thirdNumber + " is with sign \"-\"");
    }
})();