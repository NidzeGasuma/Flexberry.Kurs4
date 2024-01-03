import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-kurs4-выгр-файла-l');
  this.route('i-i-s-kurs4-выгр-файла-e',
  { path: 'i-i-s-kurs4-выгр-файла-e/:id' });
  this.route('i-i-s-kurs4-выгр-файла-e.new',
  { path: 'i-i-s-kurs4-выгр-файла-e/new' });
  this.route('i-i-s-kurs4-еди-изм-l');
  this.route('i-i-s-kurs4-еди-изм-e',
  { path: 'i-i-s-kurs4-еди-изм-e/:id' });
  this.route('i-i-s-kurs4-еди-изм-e.new',
  { path: 'i-i-s-kurs4-еди-изм-e/new' });
  this.route('i-i-s-kurs4-загр-файла-l');
  this.route('i-i-s-kurs4-загр-файла-e',
  { path: 'i-i-s-kurs4-загр-файла-e/:id' });
  this.route('i-i-s-kurs4-загр-файла-e.new',
  { path: 'i-i-s-kurs4-загр-файла-e/new' });
  this.route('i-i-s-kurs4-конв-файлы-l');
  this.route('i-i-s-kurs4-конв-файлы-e',
  { path: 'i-i-s-kurs4-конв-файлы-e/:id' });
  this.route('i-i-s-kurs4-конв-файлы-e.new',
  { path: 'i-i-s-kurs4-конв-файлы-e/new' });
  this.route('i-i-s-kurs4-конвертация-l');
  this.route('i-i-s-kurs4-конвертация-e',
  { path: 'i-i-s-kurs4-конвертация-e/:id' });
  this.route('i-i-s-kurs4-конвертация-e.new',
  { path: 'i-i-s-kurs4-конвертация-e/new' });
  this.route('i-i-s-kurs4-настр-конв-l');
  this.route('i-i-s-kurs4-настр-конв-e',
  { path: 'i-i-s-kurs4-настр-конв-e/:id' });
  this.route('i-i-s-kurs4-настр-конв-e.new',
  { path: 'i-i-s-kurs4-настр-конв-e/new' });
  this.route('i-i-s-kurs4-расширение-l');
  this.route('i-i-s-kurs4-расширение-e',
  { path: 'i-i-s-kurs4-расширение-e/:id' });
  this.route('i-i-s-kurs4-расширение-e.new',
  { path: 'i-i-s-kurs4-расширение-e/new' });
  this.route('i-i-s-kurs4-экс-файлы-l');
  this.route('i-i-s-kurs4-экс-файлы-e',
  { path: 'i-i-s-kurs4-экс-файлы-e/:id' });
  this.route('i-i-s-kurs4-экс-файлы-e.new',
  { path: 'i-i-s-kurs4-экс-файлы-e/new' });
});

export default Router;
