// LOGIN
function login() {
    if (
        document.getElementById("username").value === "admin" &&
        document.getElementById("password").value === "admin"
    ) {
        localStorage.setItem("loggedIn", "true");
        showDashboard();
    } else {
        document.getElementById("error").innerText = "Invalid Login";
    }
}

function logout() {
    localStorage.removeItem("loggedIn");
    location.reload();
}

function showDashboard() {
    document.getElementById("loginPage").style.display = "none";
    document.getElementById("dashboard").style.display = "block";
}

if (localStorage.getItem("loggedIn")) showDashboard();

// TABS
function openTab(tab) {
    document.querySelectorAll(".tab-content").forEach(t => t.style.display = "none");
    document.getElementById(tab).style.display = "block";
}

// DATA
let records = [];
let idCounter = 1;

// SLOTS
let slots = [];
for (let i = 1; i <= 24; i++) {
    slots.push({ id: i, occupied: false });
}

// LOAD SLOT DROPDOWN
function loadSlotOptions() {
    const select = document.getElementById("slotSelect");
    select.innerHTML = '<option value="">Select Slot</option>';

    slots.forEach(s => {
        if (!s.occupied) {
            let opt = document.createElement("option");
            opt.value = s.id;
            opt.text = "Slot " + s.id;
            select.appendChild(opt);
        }
    });
}

// SLOT GRID
function renderSlots() {
    const grid = document.getElementById("slotGrid");
    if (!grid) return;

    grid.innerHTML = "";

    slots.forEach(s => {
        const div = document.createElement("div");
        div.className = "slot " + (s.occupied ? "occupied" : "available");
        div.innerText = "Slot " + s.id;
        grid.appendChild(div);
    });
}

// ADD ENTRY
function addEntry() {
    const plate = document.getElementById("plate").value;
    const type = document.getElementById("type").value;
    const owner = document.getElementById("owner").value;
    const rate = parseFloat(document.getElementById("rate").value);
    const paymentMethod = document.getElementById("paymentMethod").value;
    const selectedSlotId = parseInt(document.getElementById("slotSelect").value);

    if (!plate || !type || !owner || !rate || !paymentMethod || !selectedSlotId) {
        alert("Fill all fields");
        return;
    }

    let slot = slots.find(s => s.id === selectedSlotId);

    if (slot.occupied) {
        alert("Slot already occupied!");
        return;
    }

    slot.occupied = true;

    records.push({
        id: idCounter++,
        plate,
        type,
        owner,
        rate,
        paymentMethod,
        paymentStatus: "Pending",
        entryTime: new Date(),
        exitTime: null,
        fee: 0,
        slotId: slot.id
    });

    renderSlots();
    loadSlotOptions();
    renderTable();

    document.getElementById("plate").value = "";
    document.getElementById("type").value = "";
    document.getElementById("owner").value = "";
    document.getElementById("rate").value = "";
    document.getElementById("paymentMethod").value = "";
    document.getElementById("slotSelect").value = "";
}

// EXIT
function exitVehicle(id) {
    const r = records.find(x => x.id === id);
    r.exitTime = new Date();

    const hours = (r.exitTime - r.entryTime) / 3600000;
    r.fee = (hours * r.rate).toFixed(2);

    let slot = slots.find(s => s.id === r.slotId);
    if (slot) slot.occupied = false;

    renderSlots();
    loadSlotOptions();
    renderTable();
}

// PAY
function markPaid(id) {
    records.find(r => r.id === id).paymentStatus = "Paid";
    renderTable();
}

// DELETE
function deleteRecord(id) {
    records = records.filter(r => r.id !== id);
    renderTable();
}

// TABLE
function renderTable() {
    const tbody = document.getElementById("tableBody");
    const search = document.getElementById("searchInput").value.toLowerCase();
    const filter = document.getElementById("filterStatus").value;

    tbody.innerHTML = "";

    records
        .filter(r =>
            (r.plate.toLowerCase().includes(search) ||
                r.owner.toLowerCase().includes(search)) &&
            (filter === "" || r.paymentStatus === filter)
        )
        .forEach(r => {
            tbody.innerHTML += `
        <tr>
          <td>${r.id}</td>
          <td>${r.plate}</td>
          <td>${r.type}</td>
          <td>${r.owner}</td>
          <td>${r.slotId}</td>
          <td>${r.entryTime.toLocaleString()}</td>
          <td>${r.exitTime ? r.exitTime.toLocaleString() : "-"}</td>
          <td>${r.fee || "-"}</td>
          <td>${r.paymentStatus}</td>
          <td>${r.paymentMethod}</td>
          <td>
            ${!r.exitTime
                    ? `<button class="btn btn-danger" onclick="exitVehicle(${r.id})">Exit</button>`
                    : r.paymentStatus === "Pending"
                        ? `<button class="btn btn-success" onclick="markPaid(${r.id})">Pay</button>`
                        : `<button class="btn btn-secondary" onclick="deleteRecord(${r.id})">Delete</button>`
                }
          </td>
        </tr>
      `;
        });

    updateDashboard();
}

// STATS
function updateDashboard() {
    let revenue = 0, active = 0, completed = 0;

    records.forEach(r => {
        if (r.exitTime) {
            revenue += parseFloat(r.fee || 0);
            completed++;
        } else active++;
    });

    document.getElementById("totalRevenue").innerText = "₱ " + revenue.toFixed(2);
    document.getElementById("totalVehicles").innerText = records.length;
    document.getElementById("activeVehicles").innerText = active;
    document.getElementById("completedVehicles").innerText = completed;
}

// INIT
renderSlots();
loadSlotOptions();