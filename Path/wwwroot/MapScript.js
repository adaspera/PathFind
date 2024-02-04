var map;
export function loadMap() {

    mapboxgl.accessToken = 'pk.eyJ1IjoianVzY2lva2FzIiwiYSI6ImNsa3NpZG10bjAzajYzcW51Z291ZGNobXoifQ.gUdU5b829HdbUX-oZSf3AQ';
    map = new mapboxgl.Map({
        container: 'map', // container ID
        style: 'mapbox://styles/mapbox/navigation-day-v1', // style URL
        center: [-74.5, 40], // starting position [lng, lat]
        zoom: 9, // starting zoom
    });
}

export function calculateRoute(start, end) {
    //new mapboxgl.Marker().setLngLat("AAAAAAAAAAA"").addTo(map);
    console.log(start, end);
}
