pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                bat "dotnet build" //building the app
                echo "App is building"
            }
        }
        stage('Publish') {
            steps {
                bat "del /F /Q /S C:\\inetpub\\wwwroot\\emawebsite\\" // deleting existing files from folder
                bat "dotnet publish C:\\inetpub\\wwwroot\\emawebsite\\" //publish the app in IIS folder

            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}
    