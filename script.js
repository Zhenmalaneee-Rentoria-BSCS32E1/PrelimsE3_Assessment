function checkEvenOrOdd() {
    const inputNumber = parseInt(document.getElementById("numberInput").value);

    if (isNaN(inputNumber)) {
        document.getElementById("result").textContent = "Please enter a valid number.";
    } else {
        const result = inputNumber % 2 === 0 ? "even" : "odd";
        document.getElementById("result").textContent = `The number is ${result}.`;
    }
}