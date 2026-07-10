export function getFavorites() {
    const favorites = localStorage.getItem('sensor-favorites');
    return favorites ? JSON.parse(favorites) : [];
}

export function saveFavorites(favorites) {
    localStorage.setItem('sensor-favorites', JSON.stringify(favorites));
}

export function addFavorite(sensorId) {
    const favorites = getFavorites();
    if (!favorites.includes(sensorId)) {
        favorites.push(sensorId);
        saveFavorites(favorites);
    }
    return favorites;
}

export function removeFavorite(sensorId) {
    const favorites = getFavorites();
    const index = favorites.indexOf(sensorId);
    if (index > -1) {
        favorites.splice(index, 1);
        saveFavorites(favorites);
    }
    return favorites;
}

export function isFavorite(sensorId) {
    const favorites = getFavorites();
    return favorites.includes(sensorId);
}
