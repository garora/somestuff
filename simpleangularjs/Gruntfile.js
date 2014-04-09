module.exports = function (grunt) {

    var gruntConfig = {
        pkg: grunt.file.readJSON('package.json')
    };

        grunt.loadNpmTasks('grunt-contrib-connect');
    grunt.loadNpmTasks('grunt-contrib-jasmine');
    gruntConfig.jasmine = {
        src: {
            src: [
                'src/**/*.js',
            ],
            options: {
                host: 'http://localhost:58175/',
                specs: 'test-angular.js',
                vendor: [
                    'scripts/angular.js',
                    'scripts/jquery-2.1.0.js'
                ],
                junit: {
                    path: 'output/testresults'
                },
                keepRunner: true
            }
        }
    };
    gruntConfig.connect = {
        server: {
            options: {
                port: 58175,
                base: '.'
            }
        }
    };
    grunt.registerTask('test', ['connect:server', 'jasmine:src']);
    // grunt
    grunt.initConfig(gruntConfig);
};