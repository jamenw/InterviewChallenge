$info_challenge = Invoke-RestMethod -Method Get -Uri 'https://si-interview-api.azurewebsites.net/api/Information/Challenge'
$weather_forecast_get = Invoke-RestMethod -Method Get -Uri 'https://si-interview-api.azurewebsites.net/api/WeatherForecast/WeatherForecast'

$JSON1 = ConvertTo-Json @{
  id = 123456;
  date = "2022-03-10T00:09:31.436Z";
  temperatureC = 55;
  summary = "great salt lake smells soo good!!";
  location = "syracuse, utah";
}

$weather_forecast_post = Invoke-RestMethod -Method Post -Uri 'https://si-interview-api.azurewebsites.net/api/WeatherForecast/WeatherForecast' -Body $JSON1

$JSON2 = ConvertTo-Json @{
location = "Antarctica";
}


$weather_forecast_put =  Invoke-RestMethod -Method Put -Uri 'https://si-interview-api.azurewebsites.net/api/WeatherForecast/WeatherForecast/904949882' -Body $JSON2
$weather_forecast_location = Invoke-RestMethod -Method Get -Uri 'https://si-interview-api.azurewebsites.net/api/WeatherForecast/WeatherForecast/salt%20lake%20city'
$weather_forecast_delete = Invoke-RestMethod -Method Delete -Uri 'https://si-interview-api.azurewebsites.net/api/WeatherForecast/WeatherForecast/1095108594'