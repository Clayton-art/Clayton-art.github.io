// Array to track items
const items = [];

// Get references to DOM elements
const myList = document.getElementById('myList');
const addBtn = document.getElementById('addBtn');
const deleteBtn = document.getElementById('deleteBtn');
const cloneBtn = document.getElementById('cloneBtn');

// Add event listeners to buttons
addBtn.addEventListener('click', addItem);
deleteBtn.addEventListener('click', deleteItem);
cloneBtn.addEventListener('click', cloneLastItem);

// Function to add a random item
function addItem() {
    // Generate a random number between 1 and 100
    const randomNumber = Math.floor(Math.random() * 100) + 1;

    // Add to the array
    items.push(randomNumber);

    // Create a new <li> element
    const listItem = document.createElement('li');
    listItem.textContent = 'Item ' + randomNumber;

    // Append to the list
    myList.appendChild(listItem);
}

// Function to delete the last item
function deleteItem() {
    // Check if the list is empty
    if (myList.children.length === 0) {
        alert('List is empty! Nothing to delete.');
        return;
    }

    // Remove the last <li> from the list
    const lastItem = myList.lastChild;
    myList.removeChild(lastItem);

    // Remove the last element from the items array
    items.pop();
}

// Function to clone the last item
function cloneLastItem() {
    // Check if the list is empty
    if (myList.children.length === 0) {
        alert('List is empty! Nothing to clone.');
        return;
    }

    // Select the last <li> in the list
    const lastItem = myList.lastChild;

    // Clone it using cloneNode(true) - true means deep clone
    const clonedItem = lastItem.cloneNode(true);

    // Append the clone to the list
    myList.appendChild(clonedItem);

    // Add 'Clone' to the array to track that action
    items.push('Clone');
}
