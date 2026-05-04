(function () {
	
	const items = [];
	let counter = 1;

	
	const addBtn = document.getElementById('addBtn');
	const removeFirstBtn = document.getElementById('removeFirstBtn');
	const arrayDisplay = document.getElementById('arrayDisplay');

	function render() {
		arrayDisplay.textContent = JSON.stringify(items, null, 2);
		
		removeFirstBtn.disabled = items.length === 0;
	}

	
	addBtn.addEventListener('click', function () {
		const newItem = `Item ${counter++}`; 
		items.push(newItem);
		render(); 
	});

	
	removeFirstBtn.addEventListener('click', function () {
		if (items.length === 0) return; 
		items.shift(); 
		render();
	});

	
	render();
})();

