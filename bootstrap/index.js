function displayName(e) {
    const btn = document.getElementById('name');
    console.log(e);
    // document.write('gokul');
    btn.innerHTML = 'gokul';
}

function changeVal(e) {
    console.log(e);
    const btn = document.getElementById('nam');
    btn.innerHTML = e.target.defaultValue;
}