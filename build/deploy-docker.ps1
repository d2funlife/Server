$Branch=$env:APPVEYOR_REPO_BRANCH
$IsMaster=$Branch -eq "master"
if (!$IsMaster) {
    exit 0
}

Write-Host Starting deploy docker image

sed -i '0,/{/s/{/{\n\t"credsStore": "dotnet-server",/' ~/.docker/config.json

$env:DOCKER_PASS | docker login --username dotnetrucd --password-stdin

Write-Host Push image to docker hub

docker push dotnetru/server