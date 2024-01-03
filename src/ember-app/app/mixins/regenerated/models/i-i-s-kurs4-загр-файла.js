import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  дата: DS.attr('date'),
  путь: DS.attr('string'),
  эксФайлы: DS.belongsTo('i-i-s-kurs4-экс-файлы', { inverse: null, async: false }),
  тч_загр: DS.hasMany('i-i-s-kurs4-тч-загр', { inverse: 'загрФайла', async: false })
});

export let ValidationRules = {
  дата: {
    descriptionKey: 'models.i-i-s-kurs4-загр-файла.validations.дата.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  путь: {
    descriptionKey: 'models.i-i-s-kurs4-загр-файла.validations.путь.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  эксФайлы: {
    descriptionKey: 'models.i-i-s-kurs4-загр-файла.validations.эксФайлы.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  тч_загр: {
    descriptionKey: 'models.i-i-s-kurs4-загр-файла.validations.тч_загр.__caption__',
    validators: [
      validator('ds-error'),
      validator('has-many'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ЗагрФайлаE', 'i-i-s-kurs4-загр-файла', {
    дата: attr('Дата', { index: 0 }),
    путь: attr('Путь', { index: 1 }),
    эксФайлы: belongsTo('i-i-s-kurs4-экс-файлы', 'Эксель файл', {
      репозиторий: attr('Репозиторий', { index: 3, hidden: true }),
      имя: attr('Имя', { index: 4 })
    }, { index: 2, displayMemberPath: 'репозиторий' }),
    тч_загр: hasMany('i-i-s-kurs4-тч-загр', 'Атрибуты загрузки', {
      атрибут: attr('Атрибут', { index: 0 }),
      ограничение: attr('Ограничение', { index: 1 }),
      обязательный: attr('Обязательный', { index: 2 }),
      типАтр: attr('Тип атр', { index: 3 })
    })
  });

  modelClass.defineProjection('ЗагрФайлаL', 'i-i-s-kurs4-загр-файла', {
    дата: attr('Дата', { index: 0 }),
    путь: attr('Путь', { index: 1 }),
    эксФайлы: belongsTo('i-i-s-kurs4-экс-файлы', 'Имя', {
      имя: attr('Имя', { index: 2 })
    }, { index: -1, hidden: true })
  });
};
