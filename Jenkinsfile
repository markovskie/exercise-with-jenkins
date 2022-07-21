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
                bat "cd D:\\Documents\\Ema\\first_dotnet_ex\\exercise-with-jenkins\\MyWebApp" //positioning in the app folder
                bat "dotnet publish --output C:\\inetpub\\wwwroot\\emawebsite\\" //publish the app in IIS folder

            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}
    