$Branch=$env:APPVEYOR_REPO_BRANCH
Write-Host branch: $Branch

$IsMaster=$Branch -eq "master"
Write-Host is branch: $IsMaster
if (!$IsMaster) {
    exit 0
}

Write-Host Starting build docker
$Version=$env:APPVEYOR_BUILD_VERSION

docker build -t dotnetru/server:latest -t dotnetru/server:$Version .