'use strict';

var gulp = require('gulp');
var sass = require('gulp-sass');

gulp.task('sass', function () {
 return gulp.src('./src/sass/main.scss')
   .pipe(sass().on('error', sass.logError))
   .pipe(gulp.dest('./css'));
});

gulp.task('sass:watch', ['sass'], function () {
 gulp.watch('./src/sass/main.scss', ['sass']);
});