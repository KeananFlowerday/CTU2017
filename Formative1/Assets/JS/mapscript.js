//google maps
window.onload = function initMap() {
  var latlong = -31.001758, 25.6568993;
  var mapDiv = document.getElementById('map');
  var map = new google.maps.Map(mapDiv, {
    center : {
      lat : -31.001758,
      lng : 25.6568993
    },
    zoom : 14;
    var marker = new google.maps.Marker({
	        position: latlong,
	        title: 'Here!',
          icon:"http://mt.google.com/vt/icon?psize=30&font=fonts/arialuni_t.ttf&color=ff304C13&name=icons/spotlight/spotlight-waypoint-a.png&ax=43&ay=48&text=%E2%80%A2",
	        draggable: true,
	        map: map
	    });
	    map.setCenter(marker.getPosition());
  });
