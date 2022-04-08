const api_url = "https://jsonplaceholder.typicode.com/posts";

async function getData(url) {
  const response = await fetch(url);
  const data = await response.json();
  console.log(data);

  if (response) {
    hideloader();
  }
  show(data);
}

getData(api_url);
function hideloader() {
  document.getElementById("loader").style.display = "none";
}

function show(data) {
  let tab = `
     <tr style="border:1px solid black">
       <th style="border:1px solid black;">userId</th>
       <th style="border:1px solid black;">id</th>
       <th style="border:1px solid black;">title</th>
       <th style="border:1px solid black;">body</th>
     </tr>
     `;

  for (let r of data) {
    tab += `
     <tr >
        <td style="border:1px solid black" >${r.userId}</td>
        <td style="border:1px solid black">${r.id}</td>
        <td style="border:1px solid black">${r.title}</td>
        <td style="border:1px solid black">${r.body}</td>

     </tr>
     `;
  }

  document.getElementById("post").innerHTML = tab;
}

$("#post tr").click(function () {
  var result = $(this).children("td").first().text();
  alert(result);
});
