

module.exports = function(grunt) {

  grunt.initConfig({

    // Project configuration
    pkg: grunt.file.readJSON('package.json'),

    // Compile Sass
    sass: {
      options: {
        sourceMap: true,
        sourceComments: false,
        includePaths: [
            require("bourbon-neat").includePaths,
            require("bourbon").includePaths
        ]
      },
      dist: {
        files: {
          'assets/dist/css/site.css': 'assets/sass/site.scss'
        }
      }
    },

    // Watch and build
    watch: {
      sass: {
        files: 'assets/sass/**/*.scss',
        tasks: ['sass']
      }
    }

  });

  // Load dependencies
  grunt.loadNpmTasks('grunt-contrib-watch');
  grunt.loadNpmTasks('grunt-sass');

  // Run tasks
  grunt.registerTask('default', ['sass']);

};
