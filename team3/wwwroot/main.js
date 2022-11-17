var locations = [ 
    ['CPA', 36.300757144570916, -82.37232937852909, 1],
    ['Brooks Gym', 36.30321851813382, -82.36984655420538, 2],
    ['Carter Hall', 36.3014869348897, -82.36858090184332, 3],
    ['The Quad', 36.30391296371418, -82.36917598489421, 4],
    ['Governors Hall', 36.30328326421683, -82.36483392882752, 5],
    ['Warf-Pickel Hall', 36.30272690779999, -82.37188735368312, 6],
    ['Parking Services', 36.30528351702833, -82.36373746902656, 7],
    ['Burgin Dossett Hall', 36.30485567471416, -82.36714484574892, 8],
    ['Mini-Dome', 36.30423655481346, -82.3707852383381, 9],
    ['William B. Greene Stadium', 36.299639520994276, -82.37268003938486, 10]
  ];

  var map = new google.maps.Map(document.getElementById('map'), {
    zoom: 15,
    center: new google.maps.LatLng(36.302989, -82.369617),
    mapTypeId: google.maps.MapTypeId.ROADMAP
  });

  var infowindow = new google.maps.InfoWindow();

  var marker, i;
  var image = 'images/pirate-hat.png';

  for (i = 0; i < locations.length; i++) {  
    marker = new google.maps.Marker({
      position: new google.maps.LatLng(locations[i][1], locations[i][2]),
      map: map,
      icon: image,
    });

    google.maps.event.addListener(marker, 'click', (function(marker, i) {
      return function() {
        infowindow.setContent(locations[i][0]);
        infowindow.open(map, marker);
      }
    })(marker, i));
  }

/* Error message for when the wrong answer is typed 
const text = document.getElementById("answer");

text.addEventListener("input", (event) => {
  if (text.validity.typeMismatch) {
    text.setCustomValidity("wrong answer! Please try again.");
    text.reportValidity();
  } else {
    text.setCustomValidity("");
  }
});
*/

